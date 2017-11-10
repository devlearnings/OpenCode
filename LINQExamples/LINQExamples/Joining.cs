using System.Collections.Generic;
using System.Linq;

namespace LINQExamples
{
    public static class Joining
    {
        public static IList<StudentStandard> ExecuteJoin()
        {
            var result = Data.StudentdList.Join(Data.StandardList, student => student.StandardId,
                standard => standard.StandardId, (students, standard) => new StudentStandard { Name = students.Name, StandardDesc = standard.StandardDesc }).ToList<StudentStandard>();
            return result;
        }

        public static IEnumerable<List<StudentStandardGroup>> ExecuteGroupJoin()
        {
            var result = Data.StandardList.GroupJoin(Data.StudentdList,
                standard => standard.StandardId,
                student => student.StandardId,
                (standard, grpResult) => new List<StudentStandardGroup>
                {
                    new StudentStandardGroup{ StandardDesc = standard.StandardDesc, student = grpResult }
                    
                });

            return result;
        }
    }
}