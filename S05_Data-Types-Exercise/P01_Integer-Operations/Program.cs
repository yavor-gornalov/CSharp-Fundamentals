public class Program
{
    public static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        int fourth = int.Parse(Console.ReadLine());
        Console.WriteLine(fourth * (first + second) / third);
    }
}