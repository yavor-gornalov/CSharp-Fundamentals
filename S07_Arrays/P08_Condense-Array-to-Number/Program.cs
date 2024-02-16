internal class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

        while (nums.Count > 1)
        {
            List<int> condensed = new();
            for (int i = 1; i < nums.Count; i++)
            {
                condensed.Add(nums[i - 1] + nums[i]);
            }
            nums = condensed;
        }
        Console.WriteLine(nums[0]);
    }
}
