using System;
using System.Security.Principal;
using System.Threading;

namespace _02._Articles
{
    public class Article
    {
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
            string[] articleParts = Console.ReadLine()
                .Split(", ");
            Article article = new Article()
            {
                Autor = articleParts[2],
                Title = articleParts[0],
                Content = articleParts[1]
            };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] comandParts = Console.ReadLine()
                    .Split(": ");
                string comand = comandParts[0];
                string newData = comandParts[1];

                if (comand == "Edit")
                {
                    article.Edit(newData);
                }
                else if (comand == "ChangeAuthor")
                {
                    article.ChangeAutor(newData);
                }
                else if (comand == "Rename")
                {
                    article.Rename(newData);
                }
            }

            Console.WriteLine(article);
        }
    }
}
