using System.Collections.Generic;
using System.Linq;

namespace LINQExamples
{
    public static class Aggregation
    {
        public static int ExecuteSumGetCountOfTeenager()
        {
            int total = Data.StudentdList.Sum(s =>
            {
                if (s.Age > 12 && s.Age < 20)
                    return 1;
                else
                    return 0;
            });

            return total;
        }
    }
}