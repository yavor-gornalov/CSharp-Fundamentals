using System.Collections.Generic;
internal class Program
{
    static void Main(string[] args)
    {
        List<string> numbers = Console.ReadLine()
                                      .Split()
                                      .ToList();
        
        int numberOfRotations = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfRotations; i++)
        {
            string number = numbers[0];
            numbers.RemoveAt(0);
            numbers.Add(number);
        }

        Console.WriteLine(string.Join(" ", numbers.ToArray()));
    }
}
