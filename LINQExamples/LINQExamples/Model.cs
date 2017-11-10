using System.Collections.Generic;
using System.Linq;

namespace LINQExamples
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int StandardId { get; set; }
    }

    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardDesc { get; set; }
    }

    public class StudentStandard
    {
        public string Name { get; set; }
        public string StandardDesc { get; set; }
    }

    public class StudentStandardGroup
    {
        public string StandardDesc { get; set; }
        public IEnumerable<Students> student { get; set; }
    }
}