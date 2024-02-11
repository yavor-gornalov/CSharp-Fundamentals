using System.Diagnostics;

internal class Program
{
    static void Main()
    {
        int gamesLost = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        double expenses = 0;
        
        for (int i = 1; i <= gamesLost; i++) {
            if (i % 2 == 0) expenses += headsetPrice;
            if (i % 3 == 0) expenses += mousePrice;
            if (i % 6 == 0) expenses += keyboardPrice;
            if (i % 12 == 0) expenses += displayPrice;

        }
        Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
    }
}
