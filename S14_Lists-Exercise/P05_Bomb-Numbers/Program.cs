internal class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int[] tokens = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int bomb = tokens[0];
        int initialPower = tokens[1];

        int i = 0;
        while (nums.Contains(bomb))
        {

            if (nums[i] == bomb)
            {
                int startIdx = i - initialPower;
                int power = 2 * initialPower + 1;
                if (startIdx < 0)
                {
                    power += startIdx;
                    startIdx = 0;
                }
                if (startIdx + power >= nums.Count)
                {
                    power = nums.Count - startIdx;
                }
                nums.RemoveRange(startIdx, power);
                
                i = 0;
                continue;
            }

            i++;
        }

        Console.WriteLine(nums.Sum());
    }
}
