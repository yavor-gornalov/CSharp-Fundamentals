internal class Program
{
    static void Main()
    {
        string num = Console.ReadLine();

        num = num.StartsWith("-") ? num.Replace("-", "") : num;

        int[] numbers = num.Select((x) => int.Parse(x.ToString())).ToArray();

        int evenSum = numbers.Where((x) => x % 2 == 0).Sum();
        int oddSum = numbers.Where((x) => x % 2 != 0).Sum();

        Console.WriteLine(evenSum * oddSum);
    }
}
