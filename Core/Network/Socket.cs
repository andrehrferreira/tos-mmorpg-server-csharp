using System.Net.WebSockets;

namespace Server
{
    public interface ICharacter
    {
        string Map { get; set; }
    }

    public class Socket
    {
        public string Id;
        public WebSocket Conn;
        public string EntityId;
        public ICharacter Character;
        public string CharacterId;
        public string MapIndex;
        public bool IsConnected = false;
        public Player Player;

        public Socket(string uuid, WebSocket socket)
        {
            Id = uuid;
            Conn = socket;
            IsConnected = true;
        }

        public async Task Disconnect()
        {
            if (Conn != null && Conn.State == WebSocketState.Open)
            {
                await Conn.CloseAsync(WebSocketCloseStatus.NormalClosure, "Disconnected by server", CancellationToken.None);
                IsConnected = false;
                Conn.Dispose();
            }

            //Player?.Destroy();
        }

        public void Close()
        {
            if (Conn != null)
            {
                if (Conn.State == WebSocketState.Open)                
                    Conn.Abort();
                
                Conn.Dispose();
                IsConnected = false;
            }
        }

        public async Task Send(byte[] data)
        {
            if (Conn != null && Conn.State == WebSocketState.Open)
            {
                var buffer = new ArraySegment<byte>(data);

                try
                {
                    await Conn.SendAsync(buffer, WebSocketMessageType.Binary, true, CancellationToken.None);
                }
                catch (WebSocketException ex)
                {
                    Console.WriteLine($"WebSocket error while sending data: {ex.Message}");
                    await Disconnect();
                }
            }
        }
    }
}
