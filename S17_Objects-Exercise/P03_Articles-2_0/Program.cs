internal class Program
{
    static void Main()
    {
        Newsletter newsletter = new Newsletter();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] args = Console.ReadLine().Split(", ").ToArray();

            string title = args[0];
            string content = args[1];
            string author = args[2];

            Article newArticle = new Article(title, content, author);
            newsletter.AddArticle(newArticle);
        }
        Console.WriteLine(newsletter.ToString());
    }
}

class Newsletter
{
    public List<Article> Articles { get; set; }

    public Newsletter()
    {
        Articles = new List<Article>();
    }

    public void AddArticle(Article article) => Articles.Add(article);

    public override string ToString()
    {
        string result = "";
        foreach (Article article in Articles)
        {
            Console.WriteLine(article.ToString());
        }
        return result;
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
}