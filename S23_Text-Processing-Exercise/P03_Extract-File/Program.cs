internal class Program
{
    static void Main()
    {
        string line = Console.ReadLine();

        string file = line.Split("\\").ToArray()[^1];

        string[] tokens = file.Split(".").ToArray();
        string fileName = tokens[0];
        string fileExtension = tokens[1];

        Console.WriteLine($"File name: {fileName}\nFile extension: {fileExtension}\n");
    }
}
