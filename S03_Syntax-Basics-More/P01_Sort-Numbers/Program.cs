internal class Program
{
    static void Main()
    {
        int LENGTH = 3;

        List<int> numbers = new List<int>();

        for (int i = 0; i < LENGTH; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        numbers.Sort();
        numbers.Reverse();
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}
