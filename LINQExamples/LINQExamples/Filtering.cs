using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    public static class Filtering
    {
        public static IList<Students> ExecuteWhereAgeBetween15And20()
        {
            var result = Data.StudentdList.Where(s => s.Age >= 15 && s.Age <= 20);
            return result.ToList();
        }
    }
}
