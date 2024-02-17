using System.Diagnostics.CodeAnalysis;

internal class Program
{
    static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        if (fieldSize <= 0) return;

        int[] bugIndexes = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int[] field = new int[fieldSize];
        foreach (int bugIndex in bugIndexes)
        {
            if (bugIndex < 0 || bugIndex >= field.Length) continue;
            field[bugIndex] = 1;
        }

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "end") break;

            string[] tokens = line.Split().ToArray();

            int index = int.Parse(tokens[0]);
            string direction = tokens[1];
            int step = int.Parse(tokens[2]);

            if (index < 0 || index >= field.Length || field[index] == 0) continue;
            field[index] = 0;

            if (step < 0)
            {
                direction = direction == "right" ? "left" : "right";
                step = -step;
            }

            if (direction == "right")
            {
                int nextIndex = index + step;

                if (nextIndex >= field.Length) continue;

                for (int i = nextIndex; i < field.Length; i += step)
                {
                    if (field[i] == 1) continue;
                    field[i] = 1;
                    break;
                }
            }
            if (direction == "left")
            {
                int nextIndex = index - step;

                if (nextIndex < 0) continue;

                for (int i = nextIndex; i >= 0; i -= step)
                {
                    if (field[i] == 1) continue;
                    field[i] = 1;
                    break;
                }
            }
        }
        Console.WriteLine(string.Join(" ", field));
    }
}
