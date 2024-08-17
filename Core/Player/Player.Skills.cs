namespace Server
{
    public partial class Player : Humanoid
    {
        public override void GainSkillExperience(SkillName skill, int gain = 3, bool saveOnDatabase = true)
        {
            base.GainSkillExperience(skill, gain, saveOnDatabase);
            Save();
            SaveToDatabase();
        }

    }
}
