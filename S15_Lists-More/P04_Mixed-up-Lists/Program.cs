internal class Program
{
    static void Main()
    {
        List<int> first = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> second = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> result = new List<int>();

        while (first.Count > 0 && second.Count > 0)
        {
            result.AddRange(new List<int> { first[0], second[^1] });
            first.RemoveAt(0);
            second.RemoveAt(second.Count - 1);
        }

        List<int> range = (first.Count > second.Count) ? first : second;
        range.Sort();

        int lowerLimit = range[0];
        int upperLimit = range[1];

        result = result.Where(x => x > lowerLimit && x < upperLimit).ToList();
        result.Sort();
        Console.WriteLine(string.Join(" ", result));
    }
}
