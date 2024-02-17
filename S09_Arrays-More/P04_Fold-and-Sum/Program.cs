internal class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

        int rows = 2;
        int cols = numbers.Length / 2;

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < cols / 2; i++)
        {
            matrix[0, cols / 2 - i - 1] = numbers[i];
            matrix[0, cols / 2 + i] = numbers[2 * cols - i - 1];
        }

        for (int i = 0; i < cols; i++)
        {
            matrix[1, i] = numbers[i + cols / 2];
        }

        for (int c = 0; c < cols; c++)
        {
            Console.Write(matrix[0, c] + matrix[1, c] + " ");
        }
    }
}