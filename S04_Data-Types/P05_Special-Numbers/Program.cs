internal class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine($"{i} -> {isSpecialNumber(i)}");
        }
    }

    static bool isSpecialNumber(int n)
    {
        List<int> specialNumbers = new() { 5, 7, 11 };
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return specialNumbers.Contains(sum);
    }
}
