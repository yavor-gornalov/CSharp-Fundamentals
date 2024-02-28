internal class Program
{
    static void Main()
    {
        List<string> stringNumbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<char> text = Console.ReadLine()
            .ToList();

        List<int> indexes = stringNumbers
            .Select(x => x.Sum(d => d - '0'))
            .ToList();

        string result = "";

        for (int i = 0; i < indexes.Count; i++)
        {
            int idx = indexes[i] % text.Count;
            result += text[idx];
            text.RemoveAt(idx);
        }

        Console.WriteLine(result);
    }
}
