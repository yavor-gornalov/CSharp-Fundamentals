internal class Program
{
    static void Main()
    {
        int numberOfwagons = int.Parse(Console.ReadLine());
        int[] train = new int[numberOfwagons];

        int totalPassendgers = 0;
        for (int i = 0; i < numberOfwagons; i++)
        {
            int passendgers = int.Parse(Console.ReadLine());
            train[i] = passendgers;
            totalPassendgers += passendgers;
        }
        Console.WriteLine(string.Join(" ", train));
        Console.WriteLine(totalPassendgers);
    }
}
