namespace Server.Gameplay.Items
{
    public class AmetistNecklace : Necklance
    {
        public override string Namespace => "AmetistNecklace";
        public override string Name => "Ametist Necklace";
        public override float Weight => 1f;
        public override int GoldCost => 2000;
        public override int MaxAttrs => 2;
        public override EquipmentTier Tier => EquipmentTier.T1;

        public override Dictionary<string, string> CraftingInfo => new Dictionary<string, string>
        {
            { "Tier", "1" },
            { "Light Resistence", "2-10" },
            { "Dark Resistence", "2-10" }
        };

        public override void GenerateAttrs()
        {
            SetLightResistence(RandomHelper.MinMaxInt(2, 10));
            SetDarkResistence(RandomHelper.MinMaxInt(2, 10));
        }
    }
}
