public interface IRespawn
{
    string Map { get; set; }
    float X { get; set; }
    float Y { get; set; }
    float Z { get; set; }
    int Timer { get; set; }
    bool RespawnOnStart { get; set; }
    long Timeout { get; set; }
    List<string> Entities { get; set; }
}