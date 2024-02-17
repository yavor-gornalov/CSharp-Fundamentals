internal class Program
{
    static void Main()
    {
        int seqLength = int.Parse(Console.ReadLine());

        int bestIndex = -1;
        int bestLength = -1;
        int bestSampleNumber = -1;
        int bestSum = 0;
        int[] bestSequence = null;

        int sampleNumber = 0;
        while (true)
        {
            sampleNumber++;
            string line = Console.ReadLine();

            if (line == "Clone them!") break;

            int[] sequence = line.Split("!", StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();



            (int index, int length) = getMaxSequence(sequence);

            if ((length > bestLength)
                || (length == bestLength) && (index < bestIndex)
                || (length == bestLength) && (index == bestIndex) && (sequence.Sum() > bestSum))
            {
                bestSampleNumber = sampleNumber;
                bestSequence = sequence;
                bestLength = length;
                bestIndex = index;
                bestSum = sequence.Sum();
            }
        }
        Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSum}.");
        Console.WriteLine(string.Join(" ", bestSequence));
    }

    private static Tuple<int, int> getMaxSequence(int[] arr)
    {
        int maxIndex = -1;
        int maxCounter = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            int currentIndex = i;
            int currentCounter = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                int currentNumber = arr[i];
                int nextNumber = arr[j];

                if (currentNumber != nextNumber) break;

                currentCounter++;
            }
            if (currentCounter > maxCounter)
            {
                maxCounter = currentCounter;
                maxIndex = currentIndex;
            }
        }
        return Tuple.Create(maxIndex, maxCounter);
    }
}
