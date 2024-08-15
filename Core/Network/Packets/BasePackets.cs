using Server;

namespace Server.Packets
{
    public class PacketPongHandler : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.Pong;
    }

    public class PacketLoginHandler : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.LoginToken;
    }

    public class PacketEnterToWorldHandler : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.EnterToWorld;
    }

    public class PacketGetServerListHandler : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.GetServerList;
    }

    public class PacketMapDataHandler : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.LoadMapData;
    }

    public class PacketCreateCharacterErrorHandler : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.CreateCharacterError;
    }

    public class PacketCreateCharacterFinishHandler : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.CreateCharacterFinish;
    }
}
