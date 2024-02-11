internal class Program
{
    static void Main()
    {
        int groupSize = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();

        double currentPrice = 0;
        if (groupType == "Students")
        {
            if (dayOfWeek == "Friday") currentPrice = groupSize * 8.45;
            if (dayOfWeek == "Saturday") currentPrice = groupSize * 9.80;
            if (dayOfWeek == "Sunday") currentPrice = groupSize * 10.46;

            if (groupSize >= 30) currentPrice *= 0.85;
        }
        else if (groupType == "Business")
        {
            if (groupSize >= 100) groupSize -= 10;

            if (dayOfWeek == "Friday") currentPrice = groupSize * 10.90;
            if (dayOfWeek == "Saturday") currentPrice = groupSize * 15.60;
            if (dayOfWeek == "Sunday") currentPrice = groupSize * 16;

        }
        else if (groupType == "Regular")
        {
            if (dayOfWeek == "Friday") currentPrice = groupSize * 15;
            if (dayOfWeek == "Saturday") currentPrice = groupSize * 20;
            if (dayOfWeek == "Sunday") currentPrice = groupSize * 22.50;

            if ((groupSize >= 10 && groupSize <= 20)) currentPrice *= 0.95;
        }


        Console.WriteLine($"Total price: {currentPrice:f2}");
    }
}
