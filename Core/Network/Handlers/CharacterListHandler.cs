using DotNetEnv;
using JWT.Algorithms;
using JWT.Builder;

namespace Server.Handlers
{
    public struct CharacterListMessage
    {
        public string Token { get; private set; }

        public static CharacterListMessage FromBuffer(ByteBuffer buffer)
        {
            return new CharacterListMessage
            {
                Token = buffer.GetString()
            };
        }
    }

    public class CharacterListHandler : PacketHandler
    {
        public override ClientPacketType Type => ClientPacketType.CharacterList;

        public override async void Exec(Socket socket, ByteBuffer buffer)
        {
            var messageData = CharacterListMessage.FromBuffer(buffer);

            if(messageData.Token != null)
            {
                var decodedToken = new JwtBuilder()
                .WithAlgorithm(new HMACSHA256Algorithm())
                .WithSecret(Env.GetString("TOS_JWT_SECRET"))
                .MustVerifySignature()
                .Decode<Dictionary<string, object>>(messageData.Token);

                if (decodedToken.ContainsKey("data") && decodedToken["data"] is Dictionary<string, object> data)
                {
                    if (data.ContainsKey("masterId") && data["masterId"] is string masterId)
                    {
                        var characters = await Repository.GetAllCharacters(masterId);
                        Packet.Get(ServerPacketType.CharacterList)?.Send(socket, characters);
                    }               
                }
            }
        }
    }
}
