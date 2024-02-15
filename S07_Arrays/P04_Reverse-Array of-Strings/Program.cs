internal class Program
{
    static void Main(string[] args)
    {
        string[] items = Console.ReadLine()
                                .Split()
                                .ToArray();
        foreach (string item in items.Reverse())
        {
            Console.Write(item + ' ');
        }
    }
}
