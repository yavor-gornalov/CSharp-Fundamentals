using System.Text;

internal class Program
{
    static void Main()
    {
        StringBuilder output = new StringBuilder();
        List<string> words = Console.ReadLine()
            .Split()
            .ToList();

        foreach (var word in words)
        {
            int repetitions = word.Length;
            foreach (string repeatedWord in Enumerable.Repeat(word, repetitions))
            {
                output.Append(repeatedWord);
            }
        }
        Console.WriteLine(output);
    }
}
