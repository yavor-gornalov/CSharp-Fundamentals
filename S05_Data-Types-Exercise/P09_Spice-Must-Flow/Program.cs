using System;

public class Program
{
    public static void Main()
    {
        int DAILY_REDUCE = 10, DAILY_CONSUMPTION = 26;
        int yieldMined = 0, miningDays = 0;

        int yieldAvailable = int.Parse(Console.ReadLine());

        while (yieldAvailable >= 100)
        {
            yieldMined += yieldAvailable;
            yieldAvailable -= DAILY_REDUCE;
            yieldMined -= DAILY_CONSUMPTION;
            miningDays += 1;
        }
        yieldMined = Math.Max(yieldMined - DAILY_CONSUMPTION, 0);
        Console.WriteLine(miningDays);
        Console.WriteLine(yieldMined);
    }
}