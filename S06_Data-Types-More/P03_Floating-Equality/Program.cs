using System;

public class Program
{
    public static void Main()
    {
        double first = Math.Abs(double.Parse(Console.ReadLine()));
        double second = Math.Abs(double.Parse(Console.ReadLine()));

        double eps = 0.000001;
        bool isEqual = Math.Abs(first - second) < eps;

        Console.WriteLine(isEqual);
    }
}