public class CreateItemPayload
{
    public string AccountId { get; set; }
    public string CharacterId { get; set; }
    public string ContainerId { get; set; }
    public string ItemName { get; set; }
    public int SlotId { get; set; }
    public int Amount { get; set; }
}

public class MoveItemPayload
{
    public string ItemName { get; set; }
    public string ItemRef { get; set; }
    public int Amount { get; set; }
}

public class EquipPayload
{
    public string ItemName { get; set; }
    public string ItemRef { get; set; }
}
