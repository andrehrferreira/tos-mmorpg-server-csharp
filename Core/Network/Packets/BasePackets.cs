using Server;

namespace Server.Packets
{
    public class PacketPong: PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.Pong;
    }

    public class PacketLogin : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.LoginToken;
    }

    public class PacketEnterToWorld : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.EnterToWorld;
    }

    public class PacketGetServerList : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.GetServerList;
    }

    public class PacketMapData : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.LoadMapData;
    }

    public class PacketCreateCharacterError : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.CreateCharacterError;
    }

    public class PacketCreateCharacterFinish : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.CreateCharacterFinish;
    }
}
