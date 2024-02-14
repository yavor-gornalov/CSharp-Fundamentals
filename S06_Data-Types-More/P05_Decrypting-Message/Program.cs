using System;

public class Program
{
    public static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int numberOfSymbols = int.Parse(Console.ReadLine());

        char[] message = new char[numberOfSymbols];
        for (int i = 0; i < numberOfSymbols; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            message[i] = (char)(letter + key);
        }
        Console.WriteLine(String.Join("", message));
    }
}