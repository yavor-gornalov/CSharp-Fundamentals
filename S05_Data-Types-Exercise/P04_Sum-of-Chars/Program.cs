public class Program
{
    public static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < count; i++)
        {
            char symbol = char.Parse(Console.ReadLine());
            sum += (int)symbol;
        }
        Console.WriteLine($"The sum equals: {sum}");
    }
}