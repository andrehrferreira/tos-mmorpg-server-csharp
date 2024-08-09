using System.Text;

namespace Server
{
    public class ByteBuffer
    {
        private byte[] buffer;
        private int position;

        public ByteBuffer(byte[] data = null)
        {
            buffer = data ?? new byte[0];
            position = 0;
        }

        public static byte[] ToArrayBuffer(byte[] buffer, int startIndex = 0)
        {
            int length = buffer.Length - startIndex;
            byte[] arrayBuffer = new byte[length];
            Array.Copy(buffer, startIndex, arrayBuffer, 0, length);
            return arrayBuffer;
        }

        public static byte[] UToArrayBuffer(byte[] buffer, int startIndex = 0)
        {
            int length = buffer.Length - startIndex;
            byte[] view = new byte[length];
            Array.Copy(buffer, startIndex, view, 0, length);
            return view;
        }

        private void EnsureCapacity(int requiredBytes)
        {
            int requiredCapacity = position + requiredBytes;

            if (requiredCapacity > buffer.Length)            
                Array.Resize(ref buffer, requiredCapacity);            
        }

        public static ByteBuffer CreateEmptyByteBuffer()
        {
            return new ByteBuffer();
        }

        public static ByteBuffer CreateByteBufferFromBase64(string base64Data)
        {
            byte[] bytes = Convert.FromBase64String(base64Data);
            return new ByteBuffer(bytes);
        }

        public static List<ByteBuffer> SplitPackets(ByteBuffer combinedBuffer)
        {
            List<ByteBuffer> packets = new List<ByteBuffer>();
            byte[] bufferData = combinedBuffer.GetBuffer();
            int startPosition = 1;
            int bufferSize = bufferData.Length;

            for (int i = 1; i <= bufferSize - 4; i++)
            {
                if (bufferData[i] == 0xFE && bufferData[i + 1] == 0xFE &&
                    bufferData[i + 2] == 0xFE && bufferData[i + 3] == 0xFE)
                {
                    if (i > startPosition)
                    {
                        byte[] packetData = new byte[i - startPosition];
                        Array.Copy(bufferData, startPosition, packetData, 0, i - startPosition);
                        packets.Add(new ByteBuffer(packetData));
                    }

                    startPosition = i + 4;
                    i += 3;
                }
            }

            if (startPosition < bufferSize)
            {
                byte[] packetData = new byte[bufferSize - startPosition];
                Array.Copy(bufferData, startPosition, packetData, 0, bufferSize - startPosition);
                packets.Add(new ByteBuffer(packetData));
            }

            return packets;
        }

        public ByteBuffer PutInt32(int value)
        {
            EnsureCapacity(4);
            BitConverter.GetBytes(value).CopyTo(buffer, position);
            position += 4;
            return this;
        }

        public ByteBuffer PutUInt32(uint value)
        {
            EnsureCapacity(4);
            BitConverter.GetBytes(value).CopyTo(buffer, position);
            position += 4;
            return this;
        }

        public int GetInt32()
        {
            if (position + 4 > buffer.Length)
                throw new InvalidOperationException("Buffer underflow");

            int value = BitConverter.ToInt32(buffer, position);
            position += 4;
            return value;
        }

        public uint GetUInt32()
        {
            if (position + 4 > buffer.Length)
                throw new InvalidOperationException("Buffer underflow");

            uint value = BitConverter.ToUInt32(buffer, position);
            position += 4;
            return value;
        }

        public ByteBuffer PutByte(byte value)
        {
            EnsureCapacity(1);
            buffer[position++] = value;
            return this;
        }

        public ByteBuffer PutByte(ServerPacketType value)
        {
            EnsureCapacity(1);
            buffer[position++] = (byte)value;
            return this;
        }

        public ByteBuffer PutByte(ClientPacketType value)
        {
            EnsureCapacity(1);
            buffer[position++] = (byte)value;
            return this;
        }

        public byte GetByte()
        {
            if (position + 1 > buffer.Length)
                throw new InvalidOperationException("Buffer underflow");

            return buffer[position++];
        }

        public T GetByte<T>()
        {
            if (position + 1 > buffer.Length)
                throw new InvalidOperationException("Buffer underflow");

            byte buff = buffer[position++];
            return (T)Convert.ChangeType(buff, typeof(T));
        }

        public ByteBuffer PutBool(bool value)
        {
            return PutByte((byte)(value ? 1 : 0));
        }

        public bool GetBool()
        {
            return GetByte() != 0;
        }

        public ByteBuffer PutString(string value)
        {
            byte[] utf8Bytes = Encoding.UTF8.GetBytes(value);
            PutInt32(utf8Bytes.Length);
            EnsureCapacity(utf8Bytes.Length);
            Array.Copy(utf8Bytes, 0, buffer, position, utf8Bytes.Length);
            position += utf8Bytes.Length;
            return this;
        }

        public string GetString()
        {
            int length = GetInt32();
            if (position + length > buffer.Length)
                throw new InvalidOperationException("Buffer underflow");

            string value = Encoding.UTF8.GetString(buffer, position, length);
            position += length;
            return value;
        }

        public ByteBuffer PutFloat(float value)
        {
            EnsureCapacity(4);
            BitConverter.GetBytes(value).CopyTo(buffer, position);
            position += 4;
            return this;
        }

        public float GetFloat()
        {
            if (position + 4 > buffer.Length)
                throw new InvalidOperationException("Buffer underflow");

            float value = BitConverter.ToSingle(buffer, position);
            position += 4;
            return value;
        }

        public ByteBuffer PutVector(Vector3 vector)
        {
            PutFloat(vector.X);
            PutFloat(vector.Y);
            PutFloat(vector.Z);
            return this;
        }

        public Vector3 GetVector()
        {
            return new Vector3(GetFloat(), GetFloat(), GetFloat());
        }

        public ByteBuffer PutRotator(Rotator rotator)
        {
            PutFloat(rotator.Pitch);
            PutFloat(rotator.Yaw);
            PutFloat(rotator.Roll);
            return this;
        }

        public Rotator GetRotator()
        {
            return new Rotator(GetFloat(), GetFloat(), GetFloat());
        }

        public ByteBuffer PutId(string id)
        {
            PutInt32(GUID.ToInt(id));
            return this;
        }

        public string GetId()
        {
            int idInt = GetInt32();
            return GUID.IntToId(idInt);
        }

        public void WriteDataToBuffer(Dictionary<string, string> dataSequence, Dictionary<string, object> values)
        {
            foreach (var entry in dataSequence)
            {
                var key = entry.Key;
                var type = entry.Value;

                if (!values.TryGetValue(key, out var value))
                    continue;

                switch (type)
                {
                    case "id": PutId(value.ToString()); break;
                    case "int":
                    case "int32":
                        PutInt32(Convert.ToInt32(value));
                        break;
                    case "float": PutFloat(Convert.ToSingle(value)); break;
                    case "string": PutString(value.ToString()); break;
                    case "byte": PutByte(Convert.ToByte(value)); break;
                    case "boolean":
                    case "bool":
                        PutBool(Convert.ToBoolean(value));
                        break;
                    case "vector": PutVector((Vector3)value); break;
                    case "rotator": PutRotator((Rotator)value); break;
                    default:
                        throw new InvalidOperationException($"Unsupported data type: {type}");
                }
            }
        }

        public Dictionary<string, object> ReadDataFromBuffer(Dictionary<string, string> mapObjects)
        {
            var outValues = new Dictionary<string, object>();

            foreach (var entry in mapObjects)
            {
                var key = entry.Key;
                var type = entry.Value;
                object value = null;

                switch (type)
                {
                    case "id":
                        value = GetId();
                        break;
                    case "int":
                    case "int32":
                        value = GetInt32();
                        break;
                    case "float":
                        value = GetFloat();
                        break;
                    case "string":
                        value = GetString();
                        break;
                    case "byte":
                        value = GetByte();
                        break;
                    case "boolean":
                    case "bool":
                        value = GetBool();
                        break;
                    case "vector":
                        value = this.GetVector();
                        break;
                    case "rotator":
                        value = GetRotator();
                        break;
                    default:
                        throw new InvalidOperationException($"Unsupported data type: {type}");
                }

                outValues[key] = value;
            }

            return outValues;
        }

        public byte[] GetBuffer()
        {
            return buffer;
        }

        public string ToHex()
        {
            StringBuilder hexString = new StringBuilder(buffer.Length * 2);

            foreach (byte b in buffer)            
                hexString.AppendFormat("{0:x2}", b);
            
            return hexString.ToString();
        }
    }
}
