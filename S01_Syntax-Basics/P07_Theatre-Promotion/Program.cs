internal class Program
{
    static void Main()
    {
        string weekday = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int price = 0;

        if (age < 0 || age > 122)
        {
            Console.WriteLine("Error!");
            return;
        }


        if (weekday == "Weekday")
        {
            if (age >=0 && age <= 18) { price = 12; }
            if (age >18 && age <= 64) { price = 18; }
            if (age >64 && age <= 122) { price = 12; }
        } else if (weekday == "Weekend")
        {
            if (age > 0 && age <= 18) { price = 15; }
            if (age > 18 && age <= 64) { price = 20; }
            if (age > 64 && age <= 122) { price = 15; }
        } else if(weekday == "Holiday")
        {
            if (age > 0 && age <= 18) { price = 5; }
            if (age > 18 && age <= 64) { price = 12; }
            if (age > 64 && age <= 122) { price = 10; }
        }

        Console.WriteLine(price + "$");
    }
}
