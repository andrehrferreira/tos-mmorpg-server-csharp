using Server;

namespace Server.Packets
{
    public struct PingMessage
    {
        public int Timestamp { get; private set; }

        public static PingMessage FromBuffer(ByteBuffer buffer)
        {
            return new PingMessage
            {
                Timestamp = buffer.GetInt32()
            };
        }
    }

    public class PingHandler : PacketHandler
    {
        public override ClientPacketType Type => ClientPacketType.Ping;

        public override void Exec(Socket socket, ByteBuffer data)
        {
            var messageData = PingMessage.FromBuffer(data);

            var pongBuffer = new ByteBuffer()
                .PutByte(ServerPacketType.Pong)
                .PutInt32(messageData.Timestamp)
                .GetBuffer();

            socket.Send(pongBuffer);

            /*if (socket is { character: { Map: { } map }, entityId: { } entityId })
            {
                var mapInstance = Maps.GetMap(map);
                var entity = mapInstance.FindEntityById(entityId);

                entity?.UpdateLastInteract();
            }*/
        }
    }
}
