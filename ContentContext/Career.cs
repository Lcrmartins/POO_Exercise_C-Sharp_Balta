
using System.Collections.Generic;

namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url)
            : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }
        public int TotalNumberOfCourses => Items.Count;
        // Expression Body. There is only a get instruction.
    }
}