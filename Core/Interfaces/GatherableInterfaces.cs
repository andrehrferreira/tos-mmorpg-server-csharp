using Server;

public interface IGatherable
{
    string Map { get; set; }
    int X { get; set; }
    int Y { get; set; }
    int Z { get; set; }
    int Timer { get; set; }
    bool RespawnOnStart { get; set; }
    long Timeout { get; set; } // Usando long para representar timestamps
    List<GatherableType> Entities { get; set; }
    string MeshIndex { get; set; }
    string FoliageId { get; set; }
}