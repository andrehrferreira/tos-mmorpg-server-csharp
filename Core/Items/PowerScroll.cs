
namespace Server
{
    public class PowerScroll : Item
    {
        public override string Namespace => "PowerScroll";
        public override string Name => "Power Scroll";
        public override int GoldCost => 1000;
        public override ItemRarity Rarity => ItemRarity.Unique;
        public SkillName Skill { get; set; } = SkillName.None;
        public int Value { get; set; } = 0;

        public void Use(Player entity)
        {
            var playerSkillCap = entity.GetSkillCap(Skill);
            var playerSkill = entity.GetSkill(Skill);

            entity.Skills[Skill] = new SkillValue
            {
                Value = playerSkill.Value,
                Cap = (playerSkillCap > Value + 10) ? playerSkillCap : Value + 10,
                Experience = playerSkill.Experience
            };

            Packet.Get(ServerPacketType.SpecialMessage).Send(entity, $"{SkillNameExtensions.GetSkillNameString(Skill)} upgrade cap to {(Value + 10) * 10}");
            Packet.Get(ServerPacketType.UpdateSkillInfo).Send(entity);
            entity.Save();
            entity.SaveToDatabase();
        }

        public override void GenerateAttrs()
        {
            var skill = SkillNameExtensions.GetRandomSkillName();

            if (skill == SkillName.None)
                skill = SkillName.Language;

            Skill = skill;

            var randomValue = new Random().NextDouble();

            if (randomValue <= 0.80)
                Value = 1;
            else if (randomValue <= 0.95)
                Value = 2;
            else
                Value = 3;
        }

        public override object Serialize()
        {
            var data = base.Serialize() as Dictionary<string, object>;
            data["Skill"] = Skill;
            data["Value"] = Value;
            return data;
        }
    }
}
