internal class Program
{
    static void Main()
    {
        double savings = double.Parse(Console.ReadLine());
        List<int> initialBrumQualities = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        List<int> currentDrumQualities = new List<int>();
        currentDrumQualities.AddRange(initialBrumQualities);

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "Hit it again, Gabsy!") break;

            if (currentDrumQualities.Count == 0) break;

            int hitPower = int.Parse(line);

            for (int i = 0; i < currentDrumQualities.Count; i++)
            {
                if (currentDrumQualities[i] <= hitPower)
                {
                    int drumCost = initialBrumQualities[i] * 3;
                    if (drumCost > savings)
                    {
                        currentDrumQualities.RemoveAt(i);
                        initialBrumQualities.RemoveAt(i);
                        i--;
                        continue;
                    }
                    currentDrumQualities[i] = initialBrumQualities[i];
                    savings -= drumCost;
                    continue;
                }
                currentDrumQualities[i] -= hitPower;
            }
        }
        Console.WriteLine(string.Join(" ", currentDrumQualities));
        Console.WriteLine($"Gabsy has {savings:F2}lv.");
    }
}
