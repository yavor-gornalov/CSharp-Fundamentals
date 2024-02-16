internal class Program
{
    static void Main()
    {
        string[] firstArr = Console.ReadLine().Split().ToArray();
        string[] secondArr = Console.ReadLine().Split().ToArray();
        for (int j = 0; j < secondArr.Length; j++)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (secondArr[j].Equals(firstArr[i])) Console.Write(secondArr[j] + ' ');
            }
        }
    }
}
