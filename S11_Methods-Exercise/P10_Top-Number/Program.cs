

internal class Program
{
    static void Main()
    {
        string num = Console.ReadLine();

        for (int i = 1; i <= int.Parse(num); i++)
        {
            if (IsTopNumber(i.ToString())) Console.WriteLine(i);
        }
    }

    private static bool IsTopNumber(string num)
    {
        return isDivisible(num) && hasOddDigit(num);

    }
    private static bool isDivisible(string num)
    {
        int digithSum = 0;
        foreach (char symbol in num)
        {
            digithSum += int.Parse(symbol.ToString());
        }
        return digithSum % 8 == 0;
    }

    private static bool hasOddDigit(string num)
    {
        foreach (char symbol in num)
        {
            if ((int)symbol % 2 != 0) return true;
        }
        return false;
    }
}
