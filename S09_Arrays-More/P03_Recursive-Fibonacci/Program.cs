internal class Program
{
    static void Main()
    {
        Dictionary<int, long> initialMemo = new Dictionary<int, long>();
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(GetFibonacci(n, initialMemo));

        static long GetFibonacci(int n, Dictionary<int, long> memo)
        {
            if (n < 2)
            {
                if (!memo.ContainsKey(n)) memo.Add(n, n);
            }

            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            long result = GetFibonacci(n - 1, memo) + GetFibonacci(n - 2, memo);
            memo.Add(n, result);
            return result;
        }
    }
}
