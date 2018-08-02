using EmployeeWebApp.Models.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeWebApp.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [ScaffoldColumn(false)]
        [Required, Display(Name = "Country")]
        public int CountryId { get; set; }

        [ScaffoldColumn(false)]
        [Required, Display(Name = "State")]
        public int StateId { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }


        public EmployeeModel Mapper(Employee employee)
        {
            var employeeObj = new EmployeeModel();
            employeeObj.EmployeeId = employee.EmployeeId;
            employeeObj.Name = employee.Name;
            employeeObj.Email = employee.Email;
            employeeObj.Salary = employee.Salary;
            employeeObj.CountryId = employee.CountryId;
            employeeObj.StateId = employee.StateId;

            return employeeObj;
        }
    }
}