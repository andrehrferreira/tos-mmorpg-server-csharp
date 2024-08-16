namespace Server
{
    public struct GatherableSettings : IGatherable
    {
        public string Map { get; set; }
        public bool RespawnOnStart { get; set; }
        public long Timeout { get; set; }
        public int Timer { get; set; }
        public List<GatherableType> Entities { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int MeshIndex { get; set; }
        public string FoliageId { get; set; }
    }
}
