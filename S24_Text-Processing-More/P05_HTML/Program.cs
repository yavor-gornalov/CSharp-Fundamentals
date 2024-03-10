using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string title = Console.ReadLine();
        string article = Console.ReadLine();

        StringBuilder output = new StringBuilder();
        output.AppendLine($"<h1>\n\t{title}\n</h1>");
        output.AppendLine($"<article>\n\t{article}\n</article>");

        while (true)
        {
            string comment = Console.ReadLine();
            if (comment == "end of comments")
            {
                break;
            }
            output.AppendLine($"<div>\n\t{comment}\n</div>");
        }

        Console.WriteLine(output.ToString());
    }
}
