internal class Program
{
    static void Main()
    {
        double centuries = int.Parse(Console.ReadLine());
        double years = centuries * 100;
        double days = Math.Floor(years * 365.2422);
        double hours = Math.Floor(days * 24);
        double minutes = Math.Floor(hours * 60);

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}
