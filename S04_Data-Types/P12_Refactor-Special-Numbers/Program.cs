public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isSpecial = false;
        for (int i = 1; i <= number; i++)
        {
            int sum = 0;
            int currentNumber = i;
            while (currentNumber > 0)
            {
                sum += currentNumber % 10;
                currentNumber = currentNumber / 10;
            }
            isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine("{0} -> {1}", i, isSpecial);
        }

    }
}
