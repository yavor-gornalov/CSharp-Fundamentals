internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 7)
        {
            Console.WriteLine("Invalid day!");
            return;
        }
        DateTime dateValue = new DateTime(1, 1, n);
        Console.WriteLine(dateValue.DayOfWeek);
    }
}
