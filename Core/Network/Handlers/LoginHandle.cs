using Newtonsoft.Json;

namespace Server.Handlers
{
    public struct LoginMessage
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Applicant { get; private set; }

        public static LoginMessage FromBuffer(ByteBuffer buffer)
        {
            return new LoginMessage
            {
                Username = buffer.GetString(),
                Password = buffer.GetString(),
                Applicant = buffer.GetString(),
            };
        }
    }

    public class LoginHandle : PacketHandler
    {
        public override ClientPacketType Type => ClientPacketType.Login;

        public override async void Exec(Socket socket, ByteBuffer data)
        {
            var messageData = LoginMessage.FromBuffer(data);
            var result = await Repository.Login(messageData, Plevel.Player);

            if (result.token != null)
            {
                socket.SetAccountId(result.id);
                socket.SetToken(result.token);
                socket.SetPlevel(result.plevel);

                Logger.Log($"Client login: {socket.Id.Substring(0,6)} :: {result.id}");
                Packet.Get(ServerPacketType.LoginToken).Send(socket, result.token);
                Packet.Get(ServerPacketType.GetServerList).Send(socket, JsonConvert.SerializeObject(new { data = Repository.ServerListJson }));
            }
            else
            {
                Packet.Get(ServerPacketType.LoginToken).Send(socket, "");
            }
        }
    }
}
