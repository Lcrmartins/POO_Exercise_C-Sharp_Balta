using System;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var article = new Article();
            var career = new Career();
            var course = new Course();
            course.Level= ContentContext.Enums.EContentLevel.Initial;

        }
    }
}
