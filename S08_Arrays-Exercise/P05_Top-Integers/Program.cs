internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            bool isBigger = true;
            int currentNumber = numbers[i];
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int nextNumber = numbers[j];
                if (currentNumber <= nextNumber)
                {
                    isBigger = false;
                    break;
                };
            }
            if (isBigger) Console.Write(currentNumber + " ");
        }
    }
}
