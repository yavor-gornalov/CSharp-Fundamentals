internal class Program
{
    static void Main()
    {
        string[] str = Console.ReadLine().Split().ToArray();

        List<char> first = str[0].ToList();
        List<char> second = str[1].ToList();

        double totalSum = 0;
        while (first.Count > 0 && second.Count > 0)
        {
            totalSum += first[0] * second[0];
            first.RemoveAt(0);
            second.RemoveAt(0);
        }

        List<char> rest = (first.Count > second.Count) ? first : second;

        while (rest.Count > 0)
        {
            totalSum += rest[0];
            rest.RemoveAt(0);
        }
        Console.WriteLine(totalSum);
    }
}
