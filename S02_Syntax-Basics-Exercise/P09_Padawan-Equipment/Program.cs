internal class Program
{
    static void Main()
    {
        double amountOfMoney = double.Parse(Console.ReadLine());
        int coutnOfStudents = int.Parse(Console.ReadLine());
        double priceOfLightsabers = double.Parse(Console.ReadLine());
        double priceOfRobes = double.Parse(Console.ReadLine());
        double priceOfBelts = double.Parse(Console.ReadLine());

        double totalCost = (priceOfLightsabers * Math.Ceiling(coutnOfStudents * 1.1)) +
                            (priceOfBelts * (coutnOfStudents - coutnOfStudents / 6)) +
                            (priceOfRobes * coutnOfStudents);

        if (totalCost > amountOfMoney)
        {
            Console.WriteLine($"John will need {totalCost - amountOfMoney:F2}lv more.");
        }
        else
        {
            Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
        }
    }
}
