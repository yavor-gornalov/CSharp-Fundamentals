public class Program
{
    public static void Main()
    {
        int numberOfPeople = int.Parse(Console.ReadLine());
        int elevatorCapacity = int.Parse(Console.ReadLine());
        double numberOfCourses = Math.Ceiling((double)numberOfPeople / elevatorCapacity);
        Console.WriteLine(numberOfCourses);
    }
}