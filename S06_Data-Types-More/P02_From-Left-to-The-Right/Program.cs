using System;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            BigInteger leftNumber = BigInteger.Parse(line.Split(' ')[0]);
            BigInteger rightNumber = BigInteger.Parse(line.Split(' ')[1]);

            BigInteger number = (leftNumber >= rightNumber) ? BigInteger.Abs(leftNumber) : BigInteger.Abs(rightNumber);
            BigInteger sumDigits = 0;
            while (number > 0)
            {
                sumDigits += number % 10;
                number /= 10;
            }
            Console.WriteLine(sumDigits);
        }
    }
}