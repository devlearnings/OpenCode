using System.Collections.Generic;
using System.Linq;

namespace LINQExamples
{
    public static class Grouping
    {
        public static IList<IGrouping<string,Students>> ExecuteGroupByOnName()
        {
            var result = Data.StudentdList.GroupBy(s => s.Name).ToList();
            return result;
        }
    }
}