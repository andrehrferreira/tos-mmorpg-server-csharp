using Newtonsoft.Json;
using Server;

namespace Server.Packets
{
    public class PacketSpecialMessageHandler : Packet
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

    public class PacketTooltipHandler : Packet
    {
        public override ServerPacketType Type => ServerPacketType.Tooltip;

        public void Send(Player owner, string itemRef, Dictionary<string, object> data)
        {
            if (owner.Socket != null && !owner.TooltipSended.Contains(itemRef))
            {
                owner.TooltipSended.Add(itemRef);

                var jsonData = JsonConvert.SerializeObject(data);

                var buffer = new ByteBuffer()
                    .PutByte((byte)Type)
                    .PutString(itemRef)
                    .PutString(jsonData)
                    .GetBuffer();

                owner.Socket.Send(buffer);
            }
        }
    }

}
