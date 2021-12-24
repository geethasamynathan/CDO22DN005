using Day2demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2demo1.ViewModels;
namespace Day2demo1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        Employee emp;
        Department department;
        List<Employee> empList;
        public EmployeeController()
        {
            emp = new Employee()
            { Id = 101, Name = "Fransy", Gender = "Female", Salary = 45000 };
          //  department = new Department() { Id = 1, Name = "IT" };
            empList = new List<Employee>();
            empList.Add(emp);
           
        }
        public ActionResult Index()
        {
           
            DepartmentEmployeeViewModel viewModel = new DepartmentEmployeeViewModel();
            viewModel.Employee = emp;
            viewModel.Department = department;
            viewModel.Title = " Department - Employee Details";
            return View(viewModel); ;
        }

        public ActionResult AddNewEmployee()
        {
            return View();
        }
    }
}