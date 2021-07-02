using System;
using System.Collections.Generic;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Article About OOP", "orientation-objects"));
            articles.Add(new Article("Article About C#", "csharp"));
            articles.Add(new Article("Article About .NET", "dotnet"));
            Console.Clear();
            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
                Console.WriteLine("--------------------------");
            }



        }
    }
}
