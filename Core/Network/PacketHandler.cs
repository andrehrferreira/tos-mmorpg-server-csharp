using System.Runtime.CompilerServices;

namespace Server
{
    public abstract class PacketHandler
    {
        static readonly PacketHandler[] Handlers = new PacketHandler[1024];

        public abstract ClientPacketType Type { get; }
        public abstract void Exec(Socket socket, ByteBuffer data);

        static PacketHandler()
        {
            foreach (Type t in Namespaces.GetTypesInNamespace("Server.Handlers"))
            {
                if (!t.IsAbstract && Activator.CreateInstance(t) is PacketHandler packetHandler)                
                    Handlers[(int)packetHandler.Type] = packetHandler;                
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HandlePacket(Socket socket, ByteBuffer data, ClientPacketType type)
        {
            Handlers[(int)type]?.Exec(socket, data);
        }
    }
}
