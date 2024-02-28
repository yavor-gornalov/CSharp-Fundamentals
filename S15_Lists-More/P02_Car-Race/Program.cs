internal class Program
{
    static void Main()
    {
        List<int> track = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        double leftTime = 0;
        double rightTime = 0;

        for (int i = 0; i < track.Count / 2; i++)
        {
            leftTime += track[i];
            rightTime += track[^(i + 1)];
            if (track[i] == 0) leftTime -= 0.2 * leftTime;
            if (track[^(i + 1)] == 0) rightTime -= 0.2 * rightTime;
        }

        string winner = leftTime < rightTime ? "left" : "right";
        Console.WriteLine($"The winner is {winner} with total time: {Math.Min(leftTime, rightTime)}");
    }
}
