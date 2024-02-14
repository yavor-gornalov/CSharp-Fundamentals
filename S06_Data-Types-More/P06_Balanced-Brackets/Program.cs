using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string isBalanced = "BALANCED";
        char target = '(';

        for (int i = 0; i < n; i++)
        {
            char character;
            Char.TryParse(Console.ReadLine(), out character);
            if (character == '(' || character == ')')
            {
                if (character != target || n <= 1)
                {
                    isBalanced = "UNBALANCED";
                    break;
                }
                target = target == '(' ? ')' : '(';
            }
        }
        if (target != ')')
            Console.WriteLine(isBalanced);
        else Console.WriteLine("UNBALANCED");
    }
}