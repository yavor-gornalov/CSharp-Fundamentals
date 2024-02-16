internal class Program
{
    static void Main()
    {
        int numberOfInputLines = int.Parse(Console.ReadLine());

        int[] firstArr = new int[numberOfInputLines];
        int[] secondArr = new int[numberOfInputLines];

        for (int i = 0; i < numberOfInputLines; i++)
        {
            int[] elements = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToArray();
            if (i % 2 == 0)
            {
                firstArr[i] = elements[0];
                secondArr[i] = elements[1];
            }
            else
            {
                firstArr[i] = elements[1];
                secondArr[i] = elements[0];
            }
        }

        Console.WriteLine(string.Join(" ", firstArr));
        Console.WriteLine(string.Join(" ", secondArr));
    }
}
