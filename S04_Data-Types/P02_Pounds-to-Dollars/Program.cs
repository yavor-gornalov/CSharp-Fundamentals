internal class Program
{
    static void Main()
    {
        double COURSE = 1.31;
        Console.WriteLine($"{COURSE * double.Parse(Console.ReadLine()):F3}");
    }
}
