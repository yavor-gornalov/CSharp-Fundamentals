
internal class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        double result = GetFactorialDivision(first, second);
        Console.WriteLine($"{result:F2}");
    }

    private static double GetFactorialDivision(int first, int second)
    {
        return GetFactorial(first) / GetFactorial(second);
    }

    private static double GetFactorial(int n)
    {
        double factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
