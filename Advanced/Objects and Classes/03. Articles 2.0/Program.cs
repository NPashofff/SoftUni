using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    public class Article
    {
        public List<string> Userrs { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Autor { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAutor(string newAutor)
        {
            Autor = newAutor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Autor}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articleList = new List<Article>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] articleParts = Console.ReadLine()
                  .Split(", ");

                Article article = new Article()
                {
                    Autor = articleParts[2],
                    Title = articleParts[0],
                    Content = articleParts[1]
                };

                articleList.Add(article);
            }

            string sortKey = Console.ReadLine();
            List<Article> sorted = new List<Article>();
            if (sortKey == "autor")
            {
                sorted = articleList
                      .OrderBy(x => x.Autor)
                      .ToList();
            }
            else if (sortKey == "title")
            {
                sorted = articleList
                      .OrderBy(x => x.Title)
                      .ToList();
            }
            else if (sortKey == "content")
            {
                sorted = articleList
                      .OrderBy(x => x.Content)
                      .ToList();
            }

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
