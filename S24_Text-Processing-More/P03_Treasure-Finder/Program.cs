using System.Linq;
using System.Text;

internal class Program
{
    static void Main()
    {
        int[] key = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        while (true)
        {
            string line = Console.ReadLine();
            if (line == "find") break;

            var lineChars = line.ToCharArray();

            List<int> typeIdx = new List<int>(2);
            List<int> coordsIdx = new List<int>(2);

            for (int i = 0; i < line.Length; i++)
            {
                lineChars[i] = (char)(lineChars[i] - (key[i % key.Length]));
                if (lineChars[i] == '&')
                {
                    typeIdx.Add(i);
                }
                if (lineChars[i] == '<' || lineChars[i] == '>')
                {
                    coordsIdx.Add(i);
                }
            }

            string treasureInfo = string.Join("", lineChars);
            string treasureType = treasureInfo.Substring(typeIdx[0] + 1, typeIdx[1] - typeIdx[0] - 1);
            string treasureCoords = treasureInfo.Substring(coordsIdx[0] + 1, coordsIdx[1] - coordsIdx[0] - 1);

            Console.WriteLine($"Found {treasureType} at {treasureCoords}");

        }
    }
}
