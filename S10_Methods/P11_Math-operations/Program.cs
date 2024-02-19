internal class Program
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        char command = char.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine(Solver(firstNum, command, secondNum));
    }

    private static double Solver(int firstNum, char command, int secondNum)
    {
        switch (command)
        {
            case '+': return firstNum + secondNum;
            case '-': return firstNum - secondNum;
            case '*': return firstNum * secondNum;
            case '/':
                {
                    if (secondNum == 0) return 0;
                    else return firstNum / secondNum;
                }
            default: return 0;
        }
    }
}