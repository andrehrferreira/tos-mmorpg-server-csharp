using System.Collections.Generic;

public interface ICharacterCreatePayload
{
    string Name { get; set; }
    string Payload { get; set; }
}

public interface ICharacterPayloadInfo
{
    int Prelude { get; set; }
    string Race { get; set; }
    string Body { get; set; }
    string Head { get; set; }
    int Hair { get; set; }
    string HairColorRoot { get; set; }
    string HairColorEnd { get; set; }
    string HairColorHighlight { get; set; }
    int Beard { get; set; }
    string BeardRootColor { get; set; }
    string BeardEndColor { get; set; }
    int Genitalia { get; set; }
    int Freckles { get; set; }
    int Vitiligo { get; set; }
    string SkinColor { get; set; }
    int SkinSaturation { get; set; }
    int SkinBrightness { get; set; }
    int FacialArt { get; set; }
    string FacialArtColor { get; set; }
    int EyesShadow { get; set; }
    string EyesShadowColor { get; set; }
    string EyeslinerColor { get; set; }
    int Eyesliner { get; set; }
    int Lip { get; set; }
    int LipBrightness { get; set; }
    string LipColor { get; set; }
    bool Heterochromia { get; set; }
    string LeftEyeColor { get; set; }
    string RightEyeColor { get; set; }
    string EyesBallColor { get; set; }
    ICharacterStatus Stats { get; set; }
    Dictionary<string, ICharacterSkill> Skills { get; set; }
}

public interface ICharacterStatus
{
    int Str { get; set; }
    int Dex { get; set; }
    int Int { get; set; }
    int Vig { get; set; }
    int Agi { get; set; }
    int Luc { get; set; }
}

public interface ICharacterSkill
{
    int Index { get; set; }
    int Cap { get; set; }
    int Value { get; set; }
    int Progress { get; set; }
}

public interface ICharacter
{
    string Account { get; set; }
    string Name { get; set; }
    string Hashtag { get; set; }
    string Visual { get; set; }
    int Str { get; set; }
    int Dex { get; set; }
    int Int { get; set; }
    int Vig { get; set; }
    int Agi { get; set; }
    int Luc { get; set; }
    object Skills { get; set; } 
}

public interface IEquipament
{
    string ItemName { get; set; }
    string ItemRef { get; set; }
}

public interface ICheckHit
{
    string EntityId { get; set; }
    string ActorId { get; set; }
    float X { get; set; }
    float Y { get; set; }
    float Z { get; set; }
    int Action { get; set; }
}

public interface ICheckHitAutoAttack
{
    string EntityId { get; set; }
    string ActorId { get; set; }
    float X { get; set; }
    float Y { get; set; }
    float Z { get; set; }
}

public interface ISkillValue
{
    int Value { get; set; }
    int Cap { get; set; }
    int Experience { get; set; }
}

public interface ILevelExperience
{
    int Level { get; set; }
    int Experience { get; set; }
}
