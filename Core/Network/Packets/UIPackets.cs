using Server;

namespace Server.Packets
{
    public class PacketSpecialMessage : Packet
    {
        public override ServerPacketType Type => ServerPacketType.SpecialMessage;

        public void Send(Entity owner, string message)
        {
            if (owner != null && owner.Socket != null)
            {
                var buffer = new ByteBuffer()
                    .PutByte((byte)Type)
                    .PutString(message)
                    .GetBuffer();

                owner.Socket.Send(buffer);
            }
        }
    }

}
