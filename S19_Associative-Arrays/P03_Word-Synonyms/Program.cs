internal class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> wordSynonims = new Dictionary<string, List<string>>();

        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string word = Console.ReadLine();
            string synonim = Console.ReadLine();

            if (!wordSynonims.ContainsKey(word))
            {
                wordSynonims.Add(word, new List<string>());
            }
            wordSynonims[word].Add(synonim);
        }

        foreach (var pair in wordSynonims)
        {
            Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
        }
    }
}
