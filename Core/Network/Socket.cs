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
        public string AccountId;
        public string EntityId;
        public CharacterEntity Character { get; set; }
        public string CharacterId { get; set; }
        public string MapIndex;
        public bool IsConnected = false;
        public Player Player;
        public string DiffKey;
        public string Token;
        public Plevel Plevel;

        public Socket(string uuid, WebSocket socket)
        {
            Id = uuid;
            Conn = socket;
            IsConnected = true;
        }

        public void SetAccountId(string accountId)
        {
            AccountId = accountId;
        }

        public void SetToken(string token)
        {
            Token = token;
        }

        public void SetPlevel(Plevel plevel)
        {
            Plevel = plevel;
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
                    Logger.Error($"WebSocket error while sending data: {ex.Message}");
                    await Disconnect();
                }
            }
        }
    }
}
