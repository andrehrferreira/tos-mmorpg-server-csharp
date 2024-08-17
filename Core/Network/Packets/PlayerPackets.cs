namespace Server.Packets
{
    public class PacketCharacterList : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.CharacterList;
    }

    public class PacketFullCharacter : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.FullCharacter;
    }

    public class PacketUnstuck : PacketDirectSocket
    {
        public override ServerPacketType Type => ServerPacketType.Unstuck;
    }

    public class PacketPartyDataHandler : Packet
    {
        public override ServerPacketType Type => ServerPacketType.PartyData;

        public void Send(Entity owner, string data)
        {
            if (owner != null && owner.Socket != null)
            {
                var buffer = new ByteBuffer()
                    .PutByte((byte)Type)
                    .PutString(data)
                    .GetBuffer();

                owner.Socket.Send(buffer);
            }
        }
    }
}
