internal class Program
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        string result = "elder";
        if (age <= 2)
        {
            result = "baby";
        }
        else if (age <= 13)
        {
            result = "child";
        }
        else if (age <= 19)
        {
            result = "teenager";
        }
        else if (age <= 65)
        {
            result = "adult";
        }
        Console.WriteLine(result);
    }
}