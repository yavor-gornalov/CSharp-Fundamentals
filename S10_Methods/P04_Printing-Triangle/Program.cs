using System;

internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintRectangle(n);
    }

    private static void PrintRectangle(int n)
    {
        for (int i = 1; i <= n; i++)  PrintRectangleRow(i);

        for (int i = n - 1; i >= 1; i--) PrintRectangleRow(i);
    }

    private static void PrintRectangleRow(int n)
    {
        for (int i = 1; i <= n; i++) Console.Write(i + " ");
        Console.WriteLine();
    }
}
