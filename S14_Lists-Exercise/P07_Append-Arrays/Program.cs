internal class Program
{
    static void Main()
    {
        List<string> numbersStr = Console.ReadLine()
            .Split("|")
            .ToList();
        numbersStr.Reverse();

        List<int> numbers = new List<int>();
        foreach (string part in numbersStr)
        {
            List<int> currentList = part
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            numbers.AddRange(currentList);
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
