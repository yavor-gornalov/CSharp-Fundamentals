internal class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int[] numbers = { first, second, third };
        
        Console.WriteLine(numbers.Min());
    }
}
