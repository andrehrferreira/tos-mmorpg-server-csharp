
using System.Runtime.CompilerServices;

namespace Server
{
    public class Packet
    {
        public static Dictionary<ServerPacketType, Packet> Packets = new Dictionary<ServerPacketType, Packet>();
        public virtual ServerPacketType Type { get; protected set; }

        static Packet()
        {
            foreach (Type t in Namespaces.GetTypesInNamespace("Server.Packets"))
            {
                if (!t.IsAbstract && Activator.CreateInstance(t) is Packet packet)                
                    Packets.Add(packet.Type, packet);                
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Get<T>(ServerPacketType type) where T : Packet
        {
            if (Packets.TryGetValue(type, out var packet))
            {
                if (packet is T typedPacket)                
                    return typedPacket;                
            }

            return null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Packet Get(ServerPacketType type)
        {
            return Packets.TryGetValue(type, out Packet packet) ? packet : null;
        }

        public virtual object Data()
        {
            return null;
        }

        public virtual void Send(Socket socket, string data)
        {
            if (socket != null)
            {
                var buffer = new ByteBuffer()
                    .PutByte((byte)(int)Type)
                    .PutString(data)
                    .GetBuffer();

                socket.Send(buffer);
            }
        }

        public virtual void Send(Socket socket, object data = null, object extra = null)
        {
            if (socket != null)
            {
                var buffer = new ByteBuffer()
                    .PutByte((byte)(int)Type)
                    .PutString(data != null ? Newtonsoft.Json.JsonConvert.SerializeObject(data) : "")
                    .GetBuffer();

                socket.Send(buffer);
            }
        }

        public virtual void Send(Entity entity, object data = null, object extra = null)
        {
            if (entity.Socket != null)
            {
                var buffer = new ByteBuffer()
                    .PutByte((byte)(int)Type)
                    .PutString(data != null ? Newtonsoft.Json.JsonConvert.SerializeObject(data) : "")
                    .GetBuffer();

                entity.Socket.Send(buffer);
            }
        }

        public virtual void SendBuffer(Socket socket, ByteBuffer data, object extra = null)
        {
            socket?.Send(data.GetBuffer());
        }

        public static void Send(ServerPacketType type, Socket socket, object data = null)
        {
            var packet = Get(type);

            if (packet != null)            
                packet.SendBuffer(socket, new ByteBuffer().PutByte((byte)(int)type).PutString(Newtonsoft.Json.JsonConvert.SerializeObject(data)));
        }
    }

    public class PacketDirectSocket : Packet
    {
        public override void Send(Entity entity, object data = null, object extra = null)
        {
            if (entity.Socket != null)
            {
                var buffer = new ByteBuffer()
                    .PutByte((byte)(int)Type)
                    .PutString(data?.ToString() ?? "")
                    .GetBuffer();

                entity.Socket.Send(buffer);
            }
        }

        public override void SendBuffer(Socket socket, ByteBuffer data, object extra = null)
        {
            socket?.Send(data.GetBuffer());
        }
    }
}
