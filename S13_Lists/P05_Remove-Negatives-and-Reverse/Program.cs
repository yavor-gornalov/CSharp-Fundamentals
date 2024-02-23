internal class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        nums.RemoveAll(x => x < 0);
        nums.Reverse();
        if (nums.Count == 0)
        {
            Console.WriteLine("empty");
            return;
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}
