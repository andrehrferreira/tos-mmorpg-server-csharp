using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

public static class GameServerSettings
{
    public static string ServerGame { get; private set; }
    public static int ServerMaxPlayer { get; private set; }
    public static string ServerOverbook { get; private set; }
    public static int ServerSaveInterval { get; private set; }
    public static string ServerAutomaticRestart { get; private set; }
    public static int InitSkillPoints { get; private set; }
    public static int InitStatsPoints { get; private set; }
    public static int SkillCapperSkill { get; private set; }
    public static int SkillMaxPowerScroll { get; private set; }
    public static int SkillCap { get; private set; }
    public static int SkillUpFactor { get; private set; }
    public static string InitialMap { get; private set; }
    public static int InitialPosX { get; private set; }
    public static int InitialPosY { get; private set; }
    public static int InitialPosZ { get; private set; }

    public static void Load(string filePath)
    {
        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();

        var yamlContent = File.ReadAllText(filePath);
        var settings = deserializer.Deserialize<GameServerSettingsData>(yamlContent);

        ServerGame = settings.ServerGame;
        ServerMaxPlayer = settings.ServerMaxPlayer;
        ServerOverbook = settings.ServerOverbook;
        ServerSaveInterval = settings.ServerSaveInterval;
        ServerAutomaticRestart = settings.ServerAutomaticRestart;
        InitSkillPoints = settings.InitSkillPoints;
        InitStatsPoints = settings.InitStatsPoints;
        SkillCapperSkill = settings.SkillCapperSkill;
        SkillMaxPowerScroll = settings.SkillMaxPowerScroll;
        SkillCap = settings.SkillCap;
        SkillUpFactor = settings.SkillUpFactor;
        InitialMap = settings.InitialMap;
        InitialPosX = settings.InitialPosX;
        InitialPosY = settings.InitialPosY;
        InitialPosZ = settings.InitialPosZ;
    }
}

public class GameServerSettingsData
{
    public string ServerGame { get; set; }
    public int ServerMaxPlayer { get; set; }
    public string ServerOverbook { get; set; }
    public int ServerSaveInterval { get; set; }
    public string ServerAutomaticRestart { get; set; }
    public int InitSkillPoints { get; set; }
    public int InitStatsPoints { get; set; }
    public int SkillCapperSkill { get; set; }
    public int SkillMaxPowerScroll { get; set; }
    public int SkillCap { get; set; }
    public int SkillUpFactor { get; set; }
    public string InitialMap { get; set; }
    public int InitialPosX { get; set; }
    public int InitialPosY { get; set; }
    public int InitialPosZ { get; set; }
}
