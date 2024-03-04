internal class Program
{
    static void Main()
    {
        Dictionary<string, int> words = new Dictionary<string, int>();

        foreach (string key in Console.ReadLine()
            .Split()
            .ToArray())
        {
            string word = key.ToLower();
            if (!words.ContainsKey(word))
            {
                words.Add(word, 0);
            }
            words[word]++;
        }

        foreach (var pair in words)
        {
            if (pair.Value % 2 != 0)
            {
                Console.Write(pair.Key + " ");
            }
        }
    }
}
