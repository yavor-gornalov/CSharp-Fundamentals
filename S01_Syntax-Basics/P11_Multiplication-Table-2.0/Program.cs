internal class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine($"{firstNumber} X {secondNumber} = {firstNumber * secondNumber}");
            secondNumber += 1;
        } while (secondNumber <= 10);

    }
}
