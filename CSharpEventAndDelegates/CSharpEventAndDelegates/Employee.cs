using System;
using System.Collections.Generic;

namespace CSharpEventAndDelegates
{
    class Employee
    {
        public delegate bool PromotionCriteria(Employee emp);

        public string Name { get; set; }
        public int Exp { get; set; }

        public static void PromotedEmployees(List<Employee> employees, PromotionCriteria delPromotionCriteria)
        {
            foreach (var employee in employees)
            {
                if (delPromotionCriteria(employee))
                {
                    Console.WriteLine(employee.Name + " Promoted");
                }
            }
        }
    }
}