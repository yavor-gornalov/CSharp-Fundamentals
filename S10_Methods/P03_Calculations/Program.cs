internal class Program
{
    static void Main()
    {
        string command = Console.ReadLine();
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine(Solver(command, firstNum, secondNum));
    }

    private static double Solver(string? command, int firstNum, int secondNum)
    {
        switch (command)
        {
            case "add": return firstNum + secondNum;
            case "subtract": return firstNum - secondNum;
            case "multiply": return firstNum * secondNum;
            case "divide":
                {
                    if (secondNum == 0) return 0;
                    else return firstNum / secondNum;
                }
            default: return 0;
        }
    }
}