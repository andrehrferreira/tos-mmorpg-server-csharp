using Newtonsoft.Json;

namespace Server.Handlers
{
    public struct FullCharacterMessage
    {
        public string CharacterId { get; private set; }

        public static FullCharacterMessage FromBuffer(ByteBuffer buffer)
        {
            return new FullCharacterMessage
            {
                CharacterId = buffer.GetString()
            };
        }
    }

    public class FullCharacterHandler : PacketHandler
    {
        public override ClientPacketType Type => ClientPacketType.FullCharacter;

        public override async void Exec(Socket socket, ByteBuffer buffer)
        {
            var messageData = FullCharacterMessage.FromBuffer(buffer);

            if (Player.PlayerData.ContainsKey(messageData.CharacterId))
            {
                Console.WriteLine(messageData.CharacterId);
                var playerData = Player.ParseData(messageData.CharacterId);
                var character = JsonConvert.DeserializeObject(playerData);
                socket.Character = (CharacterEntity)character;
                socket.CharacterId = socket.Character.Id;
                Packet.Get(ServerPacketType.FullCharacter).Send(socket, playerData);
            }
        }
    }
}
