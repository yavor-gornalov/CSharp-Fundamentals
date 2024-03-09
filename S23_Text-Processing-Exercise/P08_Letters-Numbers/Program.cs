using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        double totalSum = 0;

        foreach (string word in words)
        {
            char first = word[0];
            char last = word[^1];
            double number = int.Parse(word.Substring(1, word.Length - 2));


            if (char.IsUpper(first))
            {
                number /= first - 'A' + 1;
            }
            else
            {
                number *= first - 'a' + 1;
            }

            if (char.IsUpper(last))
            {
                number -= last - 'A' + 1;
            }
            else
            {
                number += last - 'a' + 1;
            }
            totalSum += number;
        }
        Console.WriteLine($"{totalSum:F2}");
    }
}
