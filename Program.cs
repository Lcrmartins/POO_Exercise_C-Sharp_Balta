using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("Begining");
            int i = 0;
            foreach (var art in articles)
            {
                i++;
                Console.WriteLine(i);
                Console.WriteLine($"Article Id:\n{art.Id}");
                Console.WriteLine($"Article Title:\n{art.Title}");
                Console.WriteLine($"Article URL:\n{art.Url}");
                Console.WriteLine("────────────────────────────────────");
            }

            var courses = new List<Course>();
            var courseCSharp = new Course("C# Fundamentals", "csharp-fundamentals");
            var courseOOP = new Course("OOP Fundamentals", "oop-fundaments");
            var courseAspNet = new Course("ASP.NET Fundamentals", "aspdotnet-fundamentals");
            courses.Add(courseOOP);
            courses.Add(courseAspNet);
            courses.Add(courseCSharp);

            var careers = new List<Career>();
            var careerBackEnd = new Career("Back End Developer", "backend-developer");
            var careerItem2 = new CareerItem(2, "Learn Object Oriented Programing", "Learn the basis of OOP", courseOOP);
            var careerItem = new CareerItem(1, "Start Here", "Know the basis of the CSharp Language", courseCSharp);
            var careerItem3 = new CareerItem(3, "Learn .NET", "Learn the basis of DotNet", courseAspNet);
            careerBackEnd.Items.Add(careerItem2);
            careerBackEnd.Items.Add(careerItem3);
            careerBackEnd.Items.Add(careerItem);
            careers.Add(careerBackEnd);

            foreach (var career in careers)
            {
                Console.WriteLine("────────────────────────────────────");
                Console.WriteLine($"Career Guid:{career.Id.ToString()}");
                Console.WriteLine($"Career Title: {career.Title}");
                Console.WriteLine($"Career URL: {career.Url}");
                Console.WriteLine("─────────────────");
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"Course Order: {item.Order}");
                    Console.WriteLine($"Title: {item.Title}");
                    Console.WriteLine($"Description: {item.Description}");
                    Console.WriteLine($"Course {item.Course.Title}");
                    Console.WriteLine($"Course Level: {item.Course.Level}");
                    Console.WriteLine("────────");
                }
            }
            Console.WriteLine("────────────────────────────────────\n");
        }
    }
}
