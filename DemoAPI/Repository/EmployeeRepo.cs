using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoAPI.Models;

namespace DemoAPI.Repository
{
    public class EmployeeRepo:IEmployeeRepo
    {
      static  List<Employee> Employees;
        public EmployeeRepo()
        {
            Employees = new List<Employee>
            {
                new Employee{Id=1,Name="Raju",Gender="Male"},
                new Employee{Id=2,Name="Rita",Gender="Female"},
                new Employee{Id=3,Name="Peter",Gender="Male"}
            };
        }

        public Employee AddNewemployee(Employee emp)
        {
            Employees.Add(emp);
            return emp;
        }

        public List<Employee> GetAllEmployees()
        {
            return Employees;
        }

       
        public Employee GetEmployeeById(int id)
        {
            Employee emp = Employees.FirstOrDefault(e => e.Id ==id);
            return emp;
        }
    }
}