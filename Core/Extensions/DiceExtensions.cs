public static class DiceExtensions
{
    private static readonly Dictionary<Dices, string> DiceStrings = new Dictionary<Dices, string>
    {
        { Dices.None, "None" },
        { Dices.D1D4, "1D4" },
        { Dices.D2D4, "2D4" },
        { Dices.D3D4, "3D4" },
        { Dices.D4D4, "4D4" },
        { Dices.D5D4, "5D4" },
        { Dices.D6D4, "6D4" },
        { Dices.D1D6, "1D6" },
        { Dices.D2D6, "2D6" },
        { Dices.D3D6, "3D6" },
        { Dices.D4D6, "4D6" },
        { Dices.D5D6, "5D6" },
        { Dices.D6D6, "6D6" },
        { Dices.D1D8, "1D8" },
        { Dices.D2D8, "2D8" },
        { Dices.D3D8, "3D8" },
        { Dices.D4D8, "4D8" },
        { Dices.D5D8, "5D8" },
        { Dices.D6D8, "6D8" },
        { Dices.D1D10, "1D10" },
        { Dices.D2D10, "2D10" },
        { Dices.D3D10, "3D10" },
        { Dices.D4D10, "4D10" },
        { Dices.D5D10, "5D10" },
        { Dices.D6D10, "6D10" },
        { Dices.D1D12, "1D12" },
        { Dices.D2D12, "2D12" },
        { Dices.D3D12, "3D12" },
        { Dices.D4D12, "4D12" },
        { Dices.D5D12, "5D12" },
        { Dices.D6D12, "6D12" },
        { Dices.D1D20, "1D20" },
        { Dices.D2D20, "2D20" },
        { Dices.D3D20, "3D20" },
        { Dices.D4D20, "4D20" },
        { Dices.D5D20, "5D20" },
        { Dices.D6D20, "6D20" }
    };

    public static string GetDiceString(this Dices dice)
    {
        return DiceStrings[dice];
    }
}