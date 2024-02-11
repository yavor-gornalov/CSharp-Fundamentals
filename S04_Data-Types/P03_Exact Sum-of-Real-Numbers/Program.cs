internal class Program
{
    static void Main(string[] args)
    {
        int coutOfNumbers = int.Parse(Console.ReadLine());
        decimal[] numbersArr = new decimal[coutOfNumbers];
        for (int i = 0; i < coutOfNumbers; i++)
        {
            numbersArr[i] = decimal.Parse(Console.ReadLine());
        }
        Console.WriteLine(numbersArr.Sum());
    }
}
