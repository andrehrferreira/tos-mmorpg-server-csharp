namespace Server
{
    public class RespawnOptions : IRespawn
    {
        public string Map { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Z { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Timer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool RespawnOnStart { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long Timeout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Entities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class RespawnData : RespawnOptions
    {
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
