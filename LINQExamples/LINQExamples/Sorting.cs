using System.Collections.Generic;
using System.Linq;

namespace LINQExamples
{
    public static class Sorting
    {
        public static IList<Students> ExecuteOrderByOnName()
        {
            var result = Data.StudentdList.OrderBy(s => s.Name).ToList();
            return result;
        }

        public static IList<Students> ExecuteThenByOnName()
        {
            var result = Data.StudentdList.OrderBy(s => s.Name).ThenBy(s => s.Age).ToList();
            return result;
        }
    }
}