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

        public Socket(string uuid, WebSocket socket)
        {
            Id = uuid;
            Conn = socket;
            IsConnected = true;
        }

        public void Disconnect()
        {

        }

        public void Close()
        {

        }

        public void Send(byte[] data) 
        { 
        }
    }
}
