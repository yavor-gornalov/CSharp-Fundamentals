internal class Program
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());
        string result = grade < 3 ? "Failed!" : "Passed!";
        Console.WriteLine(result);
    }
}