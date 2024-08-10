public class CheckHit : ICheckHit
{
    public string EntityId { get; set; }
    public string ActorId { get; set; }
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
    public int Action { get; set; }

    public CheckHit()
    {
        EntityId = string.Empty;
        ActorId = string.Empty;
        X = 0;
        Y = 0;
        Z = 0;
        Action = -1;
    }
}
