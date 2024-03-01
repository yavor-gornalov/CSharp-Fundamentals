internal class Program
{
    static void Main()
    {
        string[] args = Console.ReadLine().Split(", ").ToArray();

        string title = args[0];
        string content = args[1];
        string author = args[2];

        Article newArticle = new Article(title, content, author);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(": ").ToArray();

            string command = tokens[0];
            string argument = tokens[1];

            switch (command)
            {
                case "Edit":
                    {
                        newArticle.Edit(argument);
                        break;
                    }
                case "ChangeAuthor":
                    {
                        newArticle.CangeAuthor(argument);
                        break;
                    }
                case "Rename":
                    {
                        newArticle.Rename(argument);
                        break;
                    }
            }
        }
        Console.WriteLine(newArticle.ToString());
    }
}

class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }

    public void Edit(string newContent)
    {
        Content = newContent;
    }

    public void CangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }

    public void Rename(string newTitle)
    {
        Title = newTitle;
    }

}