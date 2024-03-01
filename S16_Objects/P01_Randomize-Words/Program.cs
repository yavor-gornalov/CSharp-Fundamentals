internal class Program
{
    static void Main()
    {
        List<string> words = Console.ReadLine()
            .Split()
            .ToList();

        Random rnd = new Random();

        for (int i = 0; i < words.Count; i++)
        {
            int newPos = rnd.Next(words.Count);
            (words[i], words[newPos]) = (words[newPos], words[i]);
        }

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
