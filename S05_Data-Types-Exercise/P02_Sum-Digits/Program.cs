public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int digitSum = 0;
        while (number > 0)
        {
            digitSum += number % 10;
            number /= 10;
        }
        Console.WriteLine(digitSum);
    }
}