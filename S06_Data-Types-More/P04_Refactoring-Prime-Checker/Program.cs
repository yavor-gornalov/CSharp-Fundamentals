using System;

public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int currentNumber = 2; currentNumber <= number; currentNumber++)
        {
            string isPrime = "true";
            for (int divisor = 2; divisor < currentNumber; divisor++)
            {
                if (currentNumber % divisor == 0)
                {
                    isPrime = "false";
                    break;
                }
            }
            Console.WriteLine("{0} -> {1}", currentNumber, isPrime);
        }
    }
}