internal class Program
{
    static void Main()
    {
        double[] nums = Console.ReadLine()
                            .Split(' ')
                            .Select(double.Parse)
                            .ToArray();
        foreach (float num in nums)
        {
            Console.WriteLine($"{num} => {(int)Math.Round(num, MidpointRounding.AwayFromZero)}");
        }
    }
}
