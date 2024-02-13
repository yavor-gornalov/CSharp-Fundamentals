using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int maxSnowballQuality = 0, maxSnowballWeight = 0, maxSnowballTime = 0;
        BigInteger maxSnowballValue = 0;

        for (int i = 0; i < n; i++)
        {
            int snowballWeight = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            BigInteger snowballValue = BigInteger.Pow(snowballWeight / snowballTime, snowballQuality);

            if (snowballValue > maxSnowballValue)
            {
                maxSnowballValue = snowballValue;
                maxSnowballWeight = snowballWeight;
                maxSnowballTime = snowballTime;
                maxSnowballQuality = snowballQuality;
            }
        }

        Console.WriteLine($"{maxSnowballWeight} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");
    }
}
