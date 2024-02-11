internal class Program
{
    static void Main()
    {
        string numberStr = Console.ReadLine();
        int result = 0;
        foreach (var digit in numberStr.ToCharArray())
        {
            result += factorial(digit - '0');
        }

        if (int.Parse(numberStr) == result)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

        static int factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
