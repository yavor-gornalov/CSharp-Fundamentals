internal class Program
{
    static void Main()
    {
        Dictionary<char, int> letterCount = new Dictionary<char, int>();

        foreach (char letter in Console.ReadLine().ToCharArray())
        {
            if (letter == ' ') continue;

            if (!letterCount.ContainsKey(letter))
            {
                letterCount.Add(letter, 0);
            }
            letterCount[letter]++;
        }

        foreach (var pair in letterCount)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}
