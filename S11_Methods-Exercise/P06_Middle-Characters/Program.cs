
internal class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        Console.WriteLine(GetMiddleOfWord(word));


    }

    private static string GetMiddleOfWord(string? word)
    {
        int middleIndex = word.Length / 2;

        if (word.Length % 2 != 0)
        {
            return word.Substring(middleIndex, 1);
        }
        else
        {
            return word.Substring(middleIndex - 1, 2);
        }
    }
}
