internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] numbers = new string[n];
        for (int i = n - 1; i >= 0; i--) numbers[i] = Console.ReadLine();
        Console.WriteLine(string.Join(' ', numbers));
    }
}
