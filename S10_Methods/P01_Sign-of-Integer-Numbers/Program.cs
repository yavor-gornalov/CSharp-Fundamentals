
internal class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string result = CheckIsNumberPositive(number);
        Console.WriteLine(result);
    }

    private static string CheckIsNumberPositive(int number)
    {
        switch (number)
        {
            case > 0: return $"The number {number} is positive. ";
            case < 0: return $"The number {number} is negative. ";
            case 0: return $"The number {number} is zero. ";
        }
    }
}
