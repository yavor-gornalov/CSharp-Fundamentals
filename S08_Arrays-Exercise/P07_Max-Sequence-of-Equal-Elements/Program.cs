internal class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

        int maxIndex = -1;
        int maxCounter = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            int currentIndex = i;
            int currentCounter = 1;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int currentNumber = numbers[i];
                int nextNumber = numbers[j];

                if (currentNumber != nextNumber) break;

                currentCounter++;
            }
            if (currentCounter > maxCounter)
            {
                maxCounter = currentCounter;
                maxIndex = currentIndex;
            }
        }
        for (int i = 0; i < maxCounter; i++)
        {
            Console.Write(numbers[maxIndex] + " ");
        }
    }
}
