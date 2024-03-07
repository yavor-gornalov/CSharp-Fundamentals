internal class Program
{
    static void Main()
    {
        string[] bannedWords = Console.ReadLine()
            .Split(", ")
            .OrderByDescending(x => x.Length)
            .ToArray();

        string text = Console.ReadLine();

        foreach (string word in bannedWords)
        {
            string target = new String('*', word.Length);

            while (text.Contains(word))
            {
                text = text.Replace(word, target);
            }

        }
        Console.WriteLine(text);
    }
}
