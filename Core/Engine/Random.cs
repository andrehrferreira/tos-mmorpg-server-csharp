using System;

public static class RandomHelper
{
    private static readonly Random _random = new Random();

    public static int MinMaxInt(int min, int max)
    {
        if (min >= max)
            return min;

        int range = max - min + 1;
        return _random.Next(range) + min;
    }

    public static bool DropChance(double chance)
    {
        if (chance < 0.01 || chance > 100)
            return false;

        double probability = chance / 100;
        double randomNum = _random.NextDouble();
        return randomNum < probability;
    }

    public static T ArrRandom<T>(T[] array)
    {
        if (array.Length == 0)
            return default(T);

        int index = _random.Next(array.Length);
        return array[index];
    }

    public static T ArrRandom<T>(List<T> list)
    {
        if (list.Count == 0)
            return default(T);

        int index = _random.Next(list.Count);
        return list[index];
    }
}
