using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Article> articleArchive = new List<Article>();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {

                string[] inputInfo = Console.ReadLine()
                .Split(", ");
                string title = inputInfo[0];
                string content = inputInfo[1];
                string author = inputInfo[2];

                Article article = new Article(title, content, author);
                articleArchive.Add(article);
            }

            string orderBy = Console.ReadLine();
            if (orderBy == "title")
            {
                articleArchive = articleArchive
                .OrderBy(x => x.Title)
                .ToList();
            }
            else if (orderBy == "author")
            {
                articleArchive = articleArchive
                .OrderBy(x => x.Author)
                .ToList();
            }
            else if (orderBy == "content")
            {
                articleArchive = articleArchive
                .OrderBy(x => x.Content)
                .ToList();
            }

            foreach (var article in articleArchive)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
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
    }
}

