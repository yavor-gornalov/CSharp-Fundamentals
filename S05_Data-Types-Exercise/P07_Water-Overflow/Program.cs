public class Program
{
    public static void Main()
    {
        int CAPACITY = 255;
        int filledVolume = 0;
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            int currentCapacity = int.Parse(Console.ReadLine());
            if (filledVolume + currentCapacity > CAPACITY)
            {
                Console.WriteLine("Insufficient capacity!");
                continue;
            }
            filledVolume += currentCapacity;
        }
        Console.WriteLine(filledVolume);
    }
}