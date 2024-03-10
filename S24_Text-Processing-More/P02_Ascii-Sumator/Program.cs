internal class Program
{
    static void Main()
    {
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());
        char[] line = Console.ReadLine().ToCharArray();

        (char low, char high) = GetLimits(first, second);

        char[] charRange = GetCharRange(low, high, line);

        int totalSum = GetTotlaSum(charRange);
        Console.WriteLine(totalSum);
    }

    private static int GetTotlaSum(char[] charRange)
    {
        return charRange.Sum(c => c);
    }

    private static char[] GetCharRange(char low, char high, char[] line)
    {
        return line.Where(x => x > low && x < high).ToArray();
    }

    private static (char low, char high) GetLimits(char first, char second)
    {
        char[] limits = new char[] { first, second }.OrderBy(x => x).ToArray();

        return (limits[0], limits[1]);
    }
}
