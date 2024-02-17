internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int i = 1; i < n; i++) matrix[0, i] = 0;

        for (int i = 0; i < n; i++) matrix[i, 0] = 1;

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
            }
        }

        // Print the matrix 
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] != 0)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}
