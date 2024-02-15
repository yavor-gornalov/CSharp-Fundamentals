internal class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

        int evenSum = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0) evenSum += number;
        }
        Console.WriteLine(evenSum);
    }
}
