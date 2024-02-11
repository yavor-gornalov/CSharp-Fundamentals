internal class Program
{
    static void Main()
    {
        int numberOfCommands = int.Parse(Console.ReadLine());
        List<string> commands = new List<string>();
        for (int i = 0; i < numberOfCommands; i++)
        {
            commands.Add(Console.ReadLine());

        }

        foreach (string command in commands)
        {
            Console.Write(Mapper(command));
        }

        static string Mapper(string x)
        {
            int offset = x.Length - 1;
            int digit = x[^1];
            string letter = "";
            switch (digit)
            {
                case '0': letter = (' ').ToString(); break;
                case '2': letter = ((char)('a' + offset)).ToString(); break;
                case '3': letter = ((char)('d' + offset)).ToString(); break;
                case '4': letter = ((char)('g' + offset)).ToString(); break;
                case '5': letter = ((char)('j' + offset)).ToString(); break;
                case '6': letter = ((char)('m' + offset)).ToString(); break;
                case '7': letter = ((char)('p' + offset)).ToString(); break;
                case '8': letter = ((char)('t' + offset)).ToString(); break;
                case '9': letter = ((char)('w' + offset)).ToString(); break;
            }
            return letter;
        }
    }
}
