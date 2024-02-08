internal class Program
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        DateTime timeValue = new DateTime(2024, 02, 07, hours, minutes, 0);

        timeValue = timeValue.AddMinutes(30);

        Console.WriteLine(timeValue.ToString("H:mm"));

    }
}