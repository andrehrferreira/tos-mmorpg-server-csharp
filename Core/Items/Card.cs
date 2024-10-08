﻿namespace Server
{
    public abstract class Card : Item
    {
        public virtual int Attack { get; set; }
        public virtual int HP { get; set; }
        public virtual int Energy { get; set; }

        // Resistences
        public virtual int Armor { get; set; } = 0;
        public virtual int FireResistence { get; set; } = 0;
        public virtual int ColdResistence { get; set; } = 0;
        public virtual int PoisonResistence { get; set; } = 0;
        public virtual int EnergyResistence { get; set; } = 0;
        public virtual int LightResistence { get; set; } = 0;
        public virtual int DarkResistence { get; set; } = 0;

        public virtual Dictionary<AttributeType, int> Attrs { get; set; } = new Dictionary<AttributeType, int>();

        public void SetArmor(int min, int max = 0)
        {
            Armor = (max > 0) ? GetRandomIntInRange(min, max) : min;
        }

        public void SetFireResistence(int min, int max = 0)
        {
            FireResistence = (max > 0) ? GetRandomIntInRange(min, max) : min;
        }

        public void SetColdResistence(int min, int max = 0)
        {
            ColdResistence = (max > 0) ? GetRandomIntInRange(min, max) : min;
        }

        public void SetPoisonResistence(int min, int max = 0)
        {
            PoisonResistence = (max > 0) ? GetRandomIntInRange(min, max) : min;
        }

        public void SetEnergyResistence(int min, int max = 0)
        {
            EnergyResistence = (max > 0) ? GetRandomIntInRange(min, max) : min;
        }

        public void SetLightResistence(int min, int max = 0)
        {
            LightResistence = (max > 0) ? GetRandomIntInRange(min, max) : min;
        }

        public void SetDarkResistence(int min, int max = 0)
        {
            DarkResistence = (max > 0) ? GetRandomIntInRange(min, max) : min;
        }

        public void SetAttr(AttributeType attributeType, int value)
        {
            Attrs[attributeType] = value;
        }

        public override object Serialize()
        {
            var data = base.Serialize() as Dictionary<string, object>;
            data["Armor"] = Armor;
            data["FireResistence"] = FireResistence;
            data["ColdResistence"] = ColdResistence;
            data["PoisonResistence"] = PoisonResistence;
            data["EnergyResistence"] = EnergyResistence;
            data["LightResistence"] = LightResistence;
            data["DarkResistence"] = DarkResistence;
            data["Attr"] = Attrs.Select(kv => new { Type = kv.Key, Value = kv.Value }).ToList();
            data["Weight"] = Weight;
            data["GoldCost"] = GoldCost;
            return data;
        }
    }
}
