

namespace Server
{
    public class QueueBuffer
    {
        private static Dictionary<string, List<ByteBuffer>> queues = new Dictionary<string, List<ByteBuffer>>();
        private static Dictionary<string, Socket> sockets = new Dictionary<string, Socket>(); 
        private static int maxBufferSize = 512 * 1024;
        private static byte endOfPacketByte = 0xFE;
        private static int endRepeatByte = 4;

        public static void AddSocket(string id, Socket socket) 
        {
            sockets[id] = socket;
        }

        public static void RemoveSocket(string id)
        {
            if (sockets.ContainsKey(id))
                sockets.Remove(id);
        }

        public static Socket? GetSocket(string id)
        {
            return sockets.ContainsKey(id) ? sockets[id] : null;
        }

        public static void AddBuffer(string socketId, ByteBuffer buffer)
        {
            if (!queues.ContainsKey(socketId))
                queues[socketId] = new List<ByteBuffer>();

            if (!IsDuplicatePacket(socketId, buffer))
            {
                queues[socketId].Add(buffer);
                CheckAndSend(socketId);
            }
        }

        public static void CheckAndSend(string socketId)
        {
            if (queues.ContainsKey(socketId))
            {
                var buffers = queues[socketId];
                int totalSize = buffers.Sum(buffer => buffer.GetBuffer().Length);

                if (totalSize >= maxBufferSize)
                    SendBuffers(socketId);
            }
        }

        public static void SendBuffers(string socketId)
        {
            if (queues.ContainsKey(socketId))
            {
                var buffers = queues[socketId];
                if (buffers.Count > 1)
                {
                    var combinedBuffer = CombineBuffers(buffers);
                    var finalBuffer = combinedBuffer.GetBuffer();
                    GetSocket(socketId)?.Send(finalBuffer); // Replace `Send` with actual socket send method
                    queues[socketId].Clear();
                }
                else
                {
                    GetSocket(socketId)?.Send(buffers[0].GetBuffer()); // Replace `Send` with actual socket send method
                    queues[socketId].Clear();
                }
            }
        }

        private static ByteBuffer CombineBuffers(List<ByteBuffer> buffers)
        {
            int totalLength = buffers.Sum(buffer => buffer.GetBuffer().Length) + buffers.Count * endRepeatByte + 1;
            byte[] combinedArray = new byte[totalLength];
            int position = 0;

            combinedArray[position++] = (byte)ServerPacketType.Queue;

            foreach (var buffer in buffers)
            {
                var buf = buffer.GetBuffer();
                Array.Copy(buf, 0, combinedArray, position, buf.Length);
                position += buf.Length;

                for (int i = 0; i < endRepeatByte; i++)
                    combinedArray[position++] = endOfPacketByte;
            }

            return new ByteBuffer(combinedArray);
        }

        public static bool IsDuplicatePacket(string socketId, ByteBuffer buffer)
        {
            if (!queues.ContainsKey(socketId))
                return false;

            var recentPackets = queues[socketId];
            var indexBuffer = recentPackets.Select(b => b.ToHex());
            var bufferHex = buffer.ToHex();
            return indexBuffer.Contains(bufferHex);
        }

        public static void Tick(object? state)
        {
            foreach (var kvp in queues)
            {
                if (kvp.Value.Count > 0)
                    SendBuffers(kvp.Key);
            }
        }

        public static void StartTicking(int intervalMilliseconds)
        {
            Timer timer = new Timer(Tick, null, 0, intervalMilliseconds);
        }
    }
}



