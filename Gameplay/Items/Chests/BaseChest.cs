namespace Server.Gameplay.Items
{
    public abstract class BaseChest : Consumable
    {
        private readonly Dictionary<Type, LootRef> DropsPossibility = new Dictionary<Type, LootRef>();

        public void DropChance(Type cls, int chance, int amountMin, int amountMax = 1)
        {
            DropsPossibility[cls] = new LootRef(chance, amountMin, amountMax);
        }

        /*public override async Task Use(Entity entity)
        {
            if (entity is Player player && player.Socket != null)
            {
                foreach (var kvp in DropsPossibility)
                {
                    var lootRef = kvp.Value;
                    var itemType = kvp.Key;

                    if (RandomHelper.DropChance(lootRef.Chance))
                    {
                        var amount = RandomHelper.MinMaxInt(lootRef.AmountMin, lootRef.AmountMax);
                        player.AddItemByClass(itemType, amount);
                    }
                }

                await Task.CompletedTask;
            }
        }*/
    }
}
