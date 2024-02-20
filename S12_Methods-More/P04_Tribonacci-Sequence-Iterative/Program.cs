
using System.Diagnostics.Metrics;

internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> result = GetTribonacci(n);

        Console.WriteLine(string.Join(" ", result));
    }

    private static List<int> GetTribonacci(int n)
    {
        List<int> result = new List<int>();
        int a = 0; int b = 0;
        int c = 1; int counter = 0;


        while (counter < n)
        {
            result.Add(c);
            int d = a + b + c;
            a = b; b = c; c = d;
            counter++;
        }
        return result;
    }
}
