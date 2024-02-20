internal class Program
{
    static void Main()
    {
        Dictionary<int, long> memo = new Dictionary<int, long>();
        int n = int.Parse(Console.ReadLine());

        GetTribonacci(n, memo);

        for (int i = 1; i <= n; i++)
        {
            Console.Write(memo[i] + " ");
        }


        static long GetTribonacci(int n, Dictionary<int, long> memo)
        {
            if (n < 1)
            {
                if (!memo.ContainsKey(n)) memo.Add(n, 0);
            }

            if (n < 3)
            {
                if (!memo.ContainsKey(n)) memo.Add(n, 1);
            }

            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            long result = GetTribonacci(n - 1, memo) + GetTribonacci(n - 2, memo) + GetTribonacci(n - 3, memo);
            memo.Add(n, result);
            return result;
        }
    }
}