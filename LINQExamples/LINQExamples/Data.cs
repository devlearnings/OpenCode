using System.Collections.Generic;

namespace LINQExamples
{
    public static class Data
    {
        public static IList<Students> StudentdList;
        public static IList<Standard> StandardList;
        public static IList<Employee> EmpList;

        static Data()
        {
            StudentdList = new List<Students>
            {
                new Students{Id = 2, Age = 17, Name = "John", StandardId = 1},
                new Students{Id = 3, Age = 19, Name = "Steve", StandardId = 1},
                new Students{Id = 5, Age = 19, Name = "Salman", StandardId = 1},
                new Students{Id = 4, Age = 20, Name = "Raj", StandardId = 2},
                new Students{Id = 6, Age = 21, Name = "Lisa", StandardId = 3},
                new Students{Id = 6, Age = 22, Name = "Raj", StandardId = 4},
                new Students{Id = 1, Age = 25, Name = "Jay", StandardId = 4}
            };

            StandardList = new List<Standard>
            {
                new Standard{StandardId = 1,  StandardDesc = "VII"},
                new Standard{StandardId = 2,  StandardDesc = "VIII"},
                new Standard{StandardId = 3,  StandardDesc = "IX"},
                new Standard{StandardId = 4,  StandardDesc = "X"}
            };

            EmpList = new List<Employee>
            {
                new Employee{ID = 1,Name = "Jay", DeptId = 1, Salary = 100, ManagerId = 1},
                new Employee{ID = 2,Name = "John", DeptId = 1, Salary = 200, ManagerId = 1},
                new Employee{ID = 2,Name = "Raj", DeptId = 1, Salary = 300, ManagerId = 1},
                new Employee{ID = 2,Name = "Chris", DeptId = 1, Salary = 400, ManagerId = 1}
            };
        }
    }
}