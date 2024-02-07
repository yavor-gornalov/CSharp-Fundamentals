using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {
        int monthValue = int.Parse(Console.ReadLine());

        if (monthValue < 1 || monthValue > 12)
        {
            Console.WriteLine("Error!");
        }
        else
        {
            DateTime dateValue = new DateTime(2024, monthValue, 07, 0, 0, 0);
            Console.WriteLine(dateValue.ToString("MMMM", CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}