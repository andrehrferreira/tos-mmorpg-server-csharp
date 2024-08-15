using System.Collections.Concurrent;
using System.Net;
using System.Net.WebSockets;
using System.Text;

namespace Server
{
    public class WebSocketServer
    {
        private static readonly ConcurrentDictionary<WebSocket, (string, SemaphoreSlim)> clients = new();
        private static readonly ConcurrentDictionary<string, Socket> sockets = new();

        private readonly int Port;
        private readonly string ReadyMessage = "ready";
        private readonly byte[] MsgBuffer;
        private readonly ArraySegment<byte> Segment;

        public WebSocketServer(int port = 6588)
        {
            Port = port;
            MsgBuffer = Encoding.UTF8.GetBytes(ReadyMessage);
            Segment = new ArraySegment<byte>(MsgBuffer);
            QueueBuffer.StartTicking((int)(Maps.DeltaTime * 1000));
        }

        public async Task StartAsync()
        {
            HttpListener listener = new();
            listener.Prefixes.Add($"http://*:{Port}/");
            listener.Start();

            Console.WriteLine($"WebSocket server is running on ws://localhost:{Port}");

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
                    Console.WriteLine($"Listener error: {ex.Message}");
                }
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
                Console.WriteLine($"Failed to accept WebSocket: {ex.Message}");
                return;
            }

            string name = $"Client{clients.Count + 1}";
            SemaphoreSlim semaphore = new(1, 1);
            clients.TryAdd(webSocket, (name, semaphore));

            string UUID = GUID.Generate();
            Socket socket = new Socket(UUID, webSocket);
            sockets.TryAdd(UUID, socket);

            var message = new ByteBuffer()
            .PutByte(ServerPacketType.SessionId)
            .PutString(socket.Id)
            .GetBuffer();

            socket.Send(message);

            Console.WriteLine($"Client connect: {socket.Id.Substring(0, 6)}");

            try
            {
                var buffer = new ArraySegment<byte>(new byte[1024]);

                while (webSocket.State == WebSocketState.Open)
                {
                    WebSocketReceiveResult result = await webSocket.ReceiveAsync(buffer, CancellationToken.None).ConfigureAwait(false);

                    if (result.MessageType == WebSocketMessageType.Close)
                        break;

                    var receivedData = buffer.Array[..result.Count];
                    var byteBuffer = new ByteBuffer(receivedData);

                    await ProcessMessage(socket, byteBuffer);
                }
            }
            catch (WebSocketException ex)
            {
                Console.WriteLine($"WebSocket error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                await HandleDisconnect(socket);

                if (webSocket.State == WebSocketState.Open || webSocket.State == WebSocketState.CloseReceived)
                {
                    try
                    {
                        await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closed by server", CancellationToken.None).ConfigureAwait(false);
                    }
                    catch (WebSocketException ex)
                    {
                        Console.WriteLine($"WebSocket close error: {ex.Message}");
                    }
                }

                webSocket.Dispose();
                clients.TryRemove(webSocket, out _);
            }
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

            // Console.WriteLine($"Client disconnected: {socket.Id}");
        }

        private static async Task ProcessMessage(Socket socket, ByteBuffer buffer)
        {
            
            
        }
    }
}
