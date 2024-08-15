namespace Server.Packets
{
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
