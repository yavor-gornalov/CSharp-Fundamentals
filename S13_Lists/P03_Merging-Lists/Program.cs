internal class Program
{
    static void Main()
    {
        List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> result = new List<int>();

        int idx = 0;
        while (idx < first.Count && idx < second.Count)
        {
            result.Add(first[idx]);
            result.Add(second[idx]);
            idx++;
        }

        first = (first.Count > second.Count) ? first : second;
        while (idx < first.Count)
        {
            result.Add(first[idx]);
            idx++;
        }
        Console.WriteLine(string.Join(" ", result));
    }
}
