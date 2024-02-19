internal class Program
{
    static void Main()
    {
        int first = char.Parse(Console.ReadLine());
        int second = char.Parse(Console.ReadLine());

        int start = first < second ? first : second;
        int end = first >= second ? first : second;


        for (int i = start + 1; i < end; i++)
        {
            Console.Write((char)i + " ");
        }
        Console.WriteLine();

    }
}
