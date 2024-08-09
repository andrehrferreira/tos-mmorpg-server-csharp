public static class SkillNameExtensions
{
    public static string GetSkillNameString(SkillName skill)
    {
        switch (skill)
        {
            case SkillName.None: return "None";
            case SkillName.CombatWithWeapons: return "Combat With Weapons";
            case SkillName.LongRangeWeapons: return "Long Range Weapons";
            case SkillName.TwoHandedWeapons: return "Two Handed Weapons";
            case SkillName.Elementarism: return "Elementarism";
            case SkillName.Necromancy: return "Necromancy";
            case SkillName.Druidy: return "Druidy";
            case SkillName.Spirituality: return "Spirituality";
            case SkillName.MagicResistence: return "Magic Resistence";
            case SkillName.Mining: return "Mining";
            case SkillName.Herbalism: return "Herbalism";
            case SkillName.Skinning: return "Skinning";
            case SkillName.Fishing: return "Fishing";
            case SkillName.Lumberjack: return "Lumberjack";
            case SkillName.Alchemy: return "Alchemy";
            case SkillName.Blacksmithing: return "Blacksmithing";
            case SkillName.Carpentry: return "Carpentry";
            case SkillName.Tailoring: return "Tailoring";
            case SkillName.Jewelry: return "Jewelry";
            case SkillName.Enchantment: return "Enchantment";
            case SkillName.Cooking: return "Cooking";
            case SkillName.Language: return "Language";
            case SkillName.Diplomacy: return "Diplomacy";
            case SkillName.ShadowMaster: return "Shadow Master";
            case SkillName.AnimalKnowledge: return "Animal Knowledge";
            case SkillName.Musician: return "Musician";
            case SkillName.Manufacturing: return "Manufacturing";
            default: return null;
        }
    }

    public static SkillName? GetSkillNameFromFormattedString(string formattedSkillName)
    {
        switch (formattedSkillName)
        {
            case "None": return SkillName.None;
            case "Combat With Weapons": return SkillName.CombatWithWeapons;
            case "Long Range Weapons": return SkillName.LongRangeWeapons;
            case "Two Handed Weapons": return SkillName.TwoHandedWeapons;
            case "Elementarism": return SkillName.Elementarism;
            case "Necromancy": return SkillName.Necromancy;
            case "Druidy": return SkillName.Druidy;
            case "Spirituality": return SkillName.Spirituality;
            case "Magic Resistence": return SkillName.MagicResistence;
            case "Mining": return SkillName.Mining;
            case "Herbalism": return SkillName.Herbalism;
            case "Skinning": return SkillName.Skinning;
            case "Fishing": return SkillName.Fishing;
            case "Lumberjack": return SkillName.Lumberjack;
            case "Alchemy": return SkillName.Alchemy;
            case "Blacksmithing": return SkillName.Blacksmithing;
            case "Carpentry": return SkillName.Carpentry;
            case "Tailoring": return SkillName.Tailoring;
            case "Jewelry": return SkillName.Jewelry;
            case "Cooking": return SkillName.Cooking;
            case "Enchantment": return SkillName.Enchantment;
            case "Language": return SkillName.Language;
            case "Diplomacy": return SkillName.Diplomacy;
            case "Shadow Master": return SkillName.ShadowMaster;
            case "Animal Knowledge": return SkillName.AnimalKnowledge;
            case "Musician": return SkillName.Musician;
            case "Manufacturing": return SkillName.Manufacturing;
            default: return null;
        }
    }

    public static SkillName GetRandomSkillName()
    {
        Array skillValues = Enum.GetValues(typeof(SkillName));
        Random random = new Random();
        SkillName skillname = (SkillName)skillValues.GetValue(random.Next(skillValues.Length));
        return (skillname == SkillName.None || skillname == SkillName.Manufacturing) ? SkillName.Language : skillname;
    }
}
