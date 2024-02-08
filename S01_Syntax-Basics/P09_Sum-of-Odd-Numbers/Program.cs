internal class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < number; i++)
        {
            int num = 2 * i + 1;
            sum += num;
            Console.WriteLine(num);
        }
        Console.WriteLine($"Sum: {sum}");
    }
}
