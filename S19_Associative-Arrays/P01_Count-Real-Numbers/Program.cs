internal class Program
{
    static void Main()
    {
        SortedDictionary<double, double> numbersCount = new SortedDictionary<double, double>();

        foreach (double num in Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray())
        {
            if (!numbersCount.ContainsKey(num))
            {
                numbersCount.Add(num, 0);
            }
            numbersCount[num]++;
        }

        foreach (var pair in numbersCount)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}
