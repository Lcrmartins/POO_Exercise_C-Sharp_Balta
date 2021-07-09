using System;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;
using Balta.NotificationContext;
using Balta.SubscriptionContext;


// <FLUNT>
// Balta's Notifications context. Free for use.
// https://github.com/andrebaltieri/flunt 
// dotnet add package flunt

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
            Console.WriteLine("\n\n\n────────── Begining ──────────");
            int i = 0;
            foreach (var art in articles)
            {
                i++;
                Console.WriteLine($"───────────── {i} ─────────────");
                // Console.WriteLine($"Article Id:\n{art.Id}");
                Console.WriteLine($"Article Title: {art.Title}");
                Console.WriteLine($"Article URL: {art.Url}");
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
            var careerItem3 = new CareerItem(3, "Learn .NET", "Learn the basis of DotNet", null);
            careerBackEnd.Items.Add(careerItem2);
            careerBackEnd.Items.Add(careerItem3);
            careerBackEnd.Items.Add(careerItem);
            careers.Add(careerBackEnd);

            foreach (var career in careers)
            {
                Console.WriteLine($"\n\n\n─────────── {career.Title} ────────────");
                // Console.WriteLine($"Career Guid:{career.Id.ToString()}");
                Console.WriteLine($"Career URL: {career.Url}");
                Console.WriteLine("─────────────────");
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"Course {item.Order} - {item.Title}");
                    Console.WriteLine($"Description: {item.Description}");
                    Console.WriteLine($"Course {item.Course?.Title}");
                    Console.WriteLine($"Course Level: {item.Course?.Level}");
                    Console.WriteLine("────────");

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
            
            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);            

            Console.WriteLine("────────────── End ──────────────────\n");
        }
    }
}
