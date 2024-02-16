internal class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();
        int indexFound = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            int leftSum = 0;
            for (int j = 0; j < i; j++)
            {
                leftSum += numbers[j];
            }
            int rightSum = 0;
            for (int k = i + 1; k < numbers.Length; k++)
            {
                rightSum += numbers[k];
            }
            if (leftSum == rightSum)
            {
                indexFound = i;
                break;
            }
        }
        Console.WriteLine(indexFound != -1 ? indexFound : "no");
    }
}
