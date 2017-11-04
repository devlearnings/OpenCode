using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLamdaExpression
{
    class Program
    {
        public static IList<Students> StudentsList { get; set; }

        static void Main(string[] args)
        {
            GetStudents();
            DisplayResult(StudentsList);

            Console.WriteLine("Available Inputs");
            Console.WriteLine("1 : GetTeenAgeStudents");

            switch (Console.ReadLine())
            {
                case "1":
                    var result = GetTeenAgeStudents();
                    DisplayResult(result);
                    break;
                default:
                    Console.WriteLine("Incorrect Input !!");
                    break;
            }

            Console.ReadLine();
        }

        private static void DisplayResult(IList<Students> list)
        {
            Console.WriteLine("\n\n------------------------------------------------------------");
            list.ToList().ForEach(s => Console.WriteLine("ID : " + s.Id + ", Name : " + s.Name + ", Age : " + s.Age));
            Console.WriteLine("------------------------------------------------------------\n\n");
            
        }

        //Generate List of students
        private static void GetStudents()
        {
            StudentsList = new List<Students>
            {
                new Students() {Id = 1, Age = 14, Name = "Jay"},
                new Students() {Id = 1, Age = 20, Name = "Rahul"},
                new Students() {Id = 1, Age = 24, Name = "Raj"},
                new Students() {Id = 1, Age = 25, Name = "Sagar"}
            };
        }

        //Lamda Expression 
        private static List<Students> GetTeenAgeStudents()
        {
            var result = StudentsList.Where(s => s.Age > 12 && s.Age < 19).ToList<Students>();
            return result;
        }
    }
}
