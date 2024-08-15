namespace Server
{
    public partial class Player : Humanoid
    {
        public class SteamAchievementSkill
        {
            public SkillName Skill { get; }
            public int Value { get; }
            public string AchievementName { get; }

            public SteamAchievementSkill(SkillName skill, int value, string achievementName)
            {
                Skill = skill;
                Value = value;
                AchievementName = achievementName;
            }
        }

        public List<string> SteamArchivements { get; set; } = new List<string>();

        public List<SteamAchievementSkill> SteamAchievementsSkill { get; set; } = new List<SteamAchievementSkill>
        {
            new SteamAchievementSkill(SkillName.Mining, 5, "MINIG50"),
            new SteamAchievementSkill(SkillName.Mining, 8, "MINIG80"),
            new SteamAchievementSkill(SkillName.Mining, 10, "MINIG100"),
            new SteamAchievementSkill(SkillName.Lumberjack, 5, "LUMBERJACK50"),
            new SteamAchievementSkill(SkillName.Lumberjack, 8, "LUMBERJACK80"),
            new SteamAchievementSkill(SkillName.Lumberjack, 10, "LUMBERJACK100"),
            new SteamAchievementSkill(SkillName.Skinning, 5, "SKINNING50"),
            new SteamAchievementSkill(SkillName.Skinning, 8, "SKINNING80"),
            new SteamAchievementSkill(SkillName.Skinning, 10, "SKINNING100"),
            new SteamAchievementSkill(SkillName.Herbalism, 5, "HERBALISM50"),
            new SteamAchievementSkill(SkillName.Herbalism, 8, "HERBALISM80"),
            new SteamAchievementSkill(SkillName.Herbalism, 10, "HERBALISM100"),
            new SteamAchievementSkill(SkillName.Blacksmithing, 10, "BLACKSMITHMASTER"),
            new SteamAchievementSkill(SkillName.Tailoring, 10, "TAILORINGMASTER"),
            new SteamAchievementSkill(SkillName.Carpentry, 10, "CARPENTRYMASTER"),
            new SteamAchievementSkill(SkillName.Alchemy, 10, "ALCHEMISTMASTER"),
            new SteamAchievementSkill(SkillName.Jewelry, 10, "JEWELRYMASTER"),
            new SteamAchievementSkill(SkillName.AnimalKnowledge, 10, "ANIMALKNOWLEDGEMASTER"),
            new SteamAchievementSkill(SkillName.Cooking, 10, "COOKINGMASTER"),
            new SteamAchievementSkill(SkillName.Enchantment, 10, "ENCHANTMENTMASTER")
        };
    }
}
