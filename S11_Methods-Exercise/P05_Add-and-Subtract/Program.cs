
internal class Program
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        Console.WriteLine(Subtract(Add(first, second), third));

    }
    private static int Add(int a, int b)
    {
        return a + b; ;
    }
    private static int Subtract(int a, int b)
    {
        return a - b;
    }
}
