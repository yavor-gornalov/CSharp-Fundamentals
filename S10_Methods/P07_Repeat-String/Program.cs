internal class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        int repetitions = int.Parse(Console.ReadLine());
        PrintText(text, repetitions);
    }

    private static void PrintText(string? t, int r)
    {
        string result = string.Concat(Enumerable.Repeat(t,r));
        Console.WriteLine(result);
    }
}
