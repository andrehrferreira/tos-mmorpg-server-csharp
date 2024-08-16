using System.Collections.Concurrent;
using System.Net;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace Server
{
    public class WebSocketServer
    {
        private static readonly ConcurrentDictionary<WebSocket, (string, SemaphoreSlim)> clients = new();
        private static readonly ConcurrentDictionary<string, Socket> sockets = new();
        private static readonly BlockingCollection<(Socket socket, ByteBuffer buffer)> messageQueue = new();

        private readonly int Port;

        public WebSocketServer(int port = 6588)
        {
            Port = port;
            QueueBuffer.StartTicking((int)(Maps.DeltaTime * 1000));
        }

        public async Task StartAsync()
        {
            Task.Factory.StartNew(() => ProcessMessages(), TaskCreationOptions.LongRunning);

            HttpListener listener = new HttpListener();

            if (listener.IsListening)
                throw new InvalidOperationException("Server is currently running.");

            listener.Prefixes.Clear();
            listener.Prefixes.Add($"http://localhost:{Port}/");

            try
            {
                listener.Start();

                Logger.Log($"WebSocket server is running on ws://localhost:{Port}");

                while (true)
                {
                    try
                    {
                        var context = await listener.GetContextAsync();

                        if (context.Request.IsWebSocketRequest)
                        {
                            _ = HandleWebSocketAsync(context);
                        }
                        else
                        {
                            context.Response.StatusCode = 400;
                            context.Response.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Error($"Listener error: {ex.Message}");
                    }
                }
            }
            catch (HttpListenerException ex)
            {
                if (ex.Message.Contains("Access is denied"))                
                    return;
                                
                throw;                
            }
        }

        private async Task HandleWebSocketAsync(HttpListenerContext context)
        {
            WebSocket webSocket;

            try
            {
                var webSocketContext = await context.AcceptWebSocketAsync(null);
                webSocket = webSocketContext.WebSocket;
            }
            catch (Exception ex)
            {
                Logger.Error($"Failed to accept WebSocket: {ex.Message}");
                return;
            }

            string UUID = GUID.Generate();
            Socket socket = new Socket(UUID, webSocket);
            sockets.TryAdd(UUID, socket);

            var message = new ByteBuffer()
            .PutByte(ServerPacketType.SessionId)
            .PutString(socket.Id)
            .GetBuffer();

            socket.Send(message);

            Logger.Log($"Client connect: {socket.Id.Substring(0, 6)}");

            // Isolar o loop de ReceiveAsync em uma thread separada
            Task.Run(async () => await ReceiveMessages(socket, webSocket));
        }

        private async Task ReceiveMessages(Socket socket, WebSocket webSocket)
        {
            var buffer = new ArraySegment<byte>(new byte[1024]);

            try
            {
                while (webSocket.State == WebSocketState.Open)
                {
                    WebSocketReceiveResult result = await webSocket.ReceiveAsync(buffer, CancellationToken.None).ConfigureAwait(false);

                    if (result.MessageType == WebSocketMessageType.Close)
                        break;

                    if (result.Count > 0)
                    {
                        var receivedData = buffer.Array[..result.Count];
                        var byteBuffer = new ByteBuffer(receivedData);
                        messageQueue.Add((socket, byteBuffer));
                    }
                }
            }
            catch (WebSocketException ex)
            {
                Logger.Error($"WebSocket error: {ex.Message}");
            }
            finally
            {
                await HandleDisconnect(socket);

                if (webSocket.State == WebSocketState.Open || webSocket.State == WebSocketState.CloseReceived)                
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closed by server", CancellationToken.None).ConfigureAwait(false);
                
                webSocket.Dispose();
            }
        }

        private void ProcessMessages()
        {
            foreach (var (socket, buffer) in messageQueue.GetConsumingEnumerable())            
                Task.Run(() => ProcessMessage(socket, buffer));            
        }

        private async Task HandleDisconnect(Socket socket)
        {
            if (socket.Character != null && socket.Character.Map != null)
            {
                var map = Maps.GetOrCreateMap(socket.Character.Map);

                if (socket.CharacterId != null && Player.Players.ContainsKey(socket.CharacterId))                
                    map.LeaveMap(Player.Players[socket.CharacterId]);                
            }

            if (socket.MapIndex != null)            
                QueueBuffer.RemoveSocket(socket.MapIndex);
            
            sockets.TryRemove(socket.Id, out _);
            clients.TryRemove(socket.Conn, out _);

            Logger.Log($"Client disconnected: {socket.Id}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static async Task ProcessMessage(Socket socket, ByteBuffer buffer)
        {
            bool isEncrypted = buffer.GetByte() == 1;
            byte[] messageBuff = ByteBuffer.ToArrayBuffer(buffer.GetBuffer(), 1);

            if(socket.DiffKey != null && isEncrypted)
            {
                ByteBuffer packet = new ByteBuffer(DecryptMessage(messageBuff, socket.DiffKey));
                ClientPacketType packetType = (ClientPacketType)packet.GetByte();

                if(packetType == ClientPacketType.Queue)
                {
                    List<ByteBuffer> packets = ByteBuffer.SplitPackets(packet);

                    foreach(var subPacket in packets)
                    {
                        ClientPacketType typeSubpacket = (ClientPacketType)subPacket.GetByte();
                        PacketHandler.HandlePacket(socket, subPacket, typeSubpacket);
                    }
                }
                else
                {
                    PacketHandler.HandlePacket(socket, packet, packetType);
                }
            }
            else if(!isEncrypted)
            {
                ByteBuffer packet = new ByteBuffer(messageBuff);
                ClientPacketType packetType = (ClientPacketType)packet.GetByte();

                if (
                    packetType == ClientPacketType.Ping ||
                    packetType == ClientPacketType.Login ||
                    packetType == ClientPacketType.LoginSteam ||
                    packetType == ClientPacketType.CharacterList ||
                    packetType == ClientPacketType.FullCharacter ||
                    packetType == ClientPacketType.EnterToWorld ||
                    packetType == ClientPacketType.CreateCharacter
                )
                {
                    PacketHandler.HandlePacket(socket, packet, packetType);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte[] DecryptMessage(byte[] encryptedData, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] decryptedBytes = new byte[encryptedData.Length];

            for (int i = 0; i < encryptedData.Length; i++)            
                decryptedBytes[i] = (byte)(encryptedData[i] ^ keyBytes[i % keyBytes.Length]);
            
            return decryptedBytes;
        }
    }
}
