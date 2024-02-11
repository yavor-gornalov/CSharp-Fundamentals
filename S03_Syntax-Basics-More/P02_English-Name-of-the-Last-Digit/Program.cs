internal class Program
{
    static void Main()
    {
        Dictionary<int, string> digits = new()
        {
            {0, "zero" },
            {1, "one" },
            {2, "two" },
            {3, "three" },
            {4, "four" },
            {5, "five" },
            {6, "six" },
            {7, "seven" },
            {8, "eight" },
            {9, "nine" },
        };

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(digits[number % 10]);
    }
}
