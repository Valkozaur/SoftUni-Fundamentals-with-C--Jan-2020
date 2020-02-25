namespace _2._Articles
{
    using System;
    class Program
    {

        static void Main(string[] args)
        {

            string[] inputInfo = Console.ReadLine()
                .Split(", ");
            string title = inputInfo[0];
            string content = inputInfo[1];
            string author = inputInfo[2];

            Article article = new Article(title, content, author);

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {

                string[] command = Console.ReadLine()
                    .Split(": ");

                string commandType = command[0];

                switch (commandType)
                {
                    case "Edit":
                        string newContent = command[1];
                        article.Edit(newContent);
                        break;

                    case "ChangeAuthor":
                        string newAuthor = command[1];
                        article.ChangeAuthor(newAuthor);
                        break;

                    case "Rename":
                        string newTitle = command[1];
                        article.Rename(newTitle);
                        break;
                }
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }

    public class Article
    {

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
    }
}
