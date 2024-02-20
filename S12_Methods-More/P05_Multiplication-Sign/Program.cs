internal class Program
{
    static void Main()
    {
        List<string> numbers = new List<string>();
        for (int i = 0; i < 3; i++)
        {
            numbers.Add(Console.ReadLine());
        }

        if (numbers.Contains("0"))
        {
            Console.WriteLine("zero");
            return;
        }

        int negativeCounter = 0;
        foreach (string number in numbers)
        {
            if (number.StartsWith('-'))
            {
                negativeCounter++;
            }
        }
        if (negativeCounter % 2 == 0) Console.WriteLine("positive");
        else Console.WriteLine("negative");

    }
}
