internal class Program
{
    static void Main()
    {
        List<char> inputList = Console.ReadLine().ToList();

        List<int> numbers = new List<int>();

        for (int i = 0; i < inputList.Count; i++)
        {
            char symbol = inputList[i];
            if (char.IsDigit(symbol))
            {
                numbers.Add(symbol - '0');
                inputList.RemoveAt(i);
                i--;
            }
        }

        string result = string.Empty;
        bool shouldSkip = true;
        foreach (int i in numbers)
        {
            shouldSkip = !shouldSkip;

            int count = i;
            count = Math.Min(i, inputList.Count);

            if (count < 1) continue;

            if (shouldSkip)
            {
                inputList.RemoveRange(0, count);
                continue;
            }
            string part = string.Join("", (inputList.Take(count).ToList()));
            inputList.RemoveRange(0, count);
            result += part;
        }
        Console.WriteLine(result);
    }
}
