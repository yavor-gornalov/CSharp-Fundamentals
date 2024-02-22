internal class Program
{
    static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Count / 2; i++)
        {
            result.Add(nums[i] + nums[nums.Count - i - 1]);
        }
        if (nums.Count % 2 != 0)
        {
            result.Add(nums[nums.Count / 2]);
        }
        Console.WriteLine(string.Join(" ", result));
    }
}
