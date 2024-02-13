using System;

public class Program
{
    public static void Main()
    {
        char symbol = char.Parse(Console.ReadLine());
        Console.WriteLine(Char.IsUpper(symbol) ? "upper-case" : "lower-case");
    }
}