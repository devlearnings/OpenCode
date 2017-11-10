using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Students> stdList = new List<Students>();

            Console.WriteLine("1: WHERE");
            Console.WriteLine("2: ORDERBY");
            Console.WriteLine("3: THENBY");
            Console.WriteLine("4: GROUPBY");
            Console.WriteLine("5: JOIN");
            Console.WriteLine("6: ALL");
            Console.WriteLine("7: SUM");

            Console.WriteLine("------------------------------------\n");

            switch (Console.ReadLine())
            {
                case "1":
                    stdList = Filtering.ExecuteWhereAgeBetween15And20();
                    break;
                case "2":
                    stdList = Sorting.ExecuteOrderByOnName();
                    break;
                case "3":
                    stdList = Sorting.ExecuteThenByOnName();
                    break;
                case "4":
                    var executeGroupByOnName = Grouping.ExecuteGroupByOnName();
                    DisplayGroupByResult(executeGroupByOnName);
                    break;
                case "5":
                    var executeJoin = Joining.ExecuteJoin();
                    DisplayJoinResult(executeJoin);
                    break;
                case "6":
                    var isAllStudentTeenager = Quantifier.ExecuteAllCheckIfAllAreTeenager();
                    Console.WriteLine("Are all students teenager ? " + (isAllStudentTeenager ? "Yes" : "No"));
                    break;
                case "7":
                    int count = Aggregation.ExecuteSumGetCountOfTeenager();
                    Console.WriteLine("Total count of teenage students : " + count);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }

            if (stdList.Count > 0)
                DisplayResult(stdList);

            Console.ReadKey();
        }

        private static void DisplayResult(IList<Students> stdList)
        {
            if (stdList.Count > 0)
            {
                stdList.ToList().ForEach(s => Console.WriteLine("Names: " + s.Name + " Age: " + s.Age));
            }
            else
            {
                Console.WriteLine("No data");
            }
        }

        private static void DisplayGroupByResult(IList<IGrouping<string, Students>> result)
        {
            result.ToList().ForEach(s =>
                {
                    Console.WriteLine("key: " + s.Key);

                    foreach (var student in s)
                    {
                        Console.WriteLine("Names: " + student.Name + " Age: " + student.Age);
                    }
                }
            );
        }

        private static void DisplayJoinResult(IList<StudentStandard> result)
        {
            result.ToList().ForEach(s => Console.WriteLine("Name: " + s.Name + " Standard: " + s.StandardDesc));
        }
    }
}
