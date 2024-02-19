internal class Program
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Pow(firstNum, secondNum));
    }
}