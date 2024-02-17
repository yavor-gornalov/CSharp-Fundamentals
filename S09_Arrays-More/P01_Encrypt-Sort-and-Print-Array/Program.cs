
internal class Program
{
    static void Main()
    {
        Dictionary<string, int> encryptedNames = new ();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            int score = CalcNamePoints(name);
            encryptedNames.Add(name, score);
        }
        encryptedNames.OrderBy(x => x.Value).ToList().ForEach(x =>
        {
            Console.WriteLine(x.Value);
        });
    }

    private static int CalcNamePoints(string? name)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        int score = 0;
        foreach (char letter in name)
        {
            if (vowels.Contains(Char.ToLower(letter)))
            {
                score += letter * name.Length;
            }
            else
            {
                score += letter / name.Length;
            }
        }
        return score;
    }
}
