using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using DemoAPI.Models;
using DemoAPI.Repository;
namespace DemoAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeRepo repo;
        public EmployeeController()
        {
            repo = new EmployeeRepo();
        }
        public List<Employee> Getemployees()
        {
            return repo.GetAllEmployees();
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = repo.GetEmployeeById(id);
            return emp;
        }
      //  [HttpGet]
        public Employee myEmployee(Employee emp)
        {
            var e1=repo.AddNewemployee(emp);
            return e1;
        }
        //List<string> names = new List<string> { "sam", "pam", "Tim" };
        // public List<string> Getvalues()
        //{
        //    return names;
        //}
        //[HttpGet]
        // public string mystring(int id)
        // {
        //     return "hello world";

        // }

    }
}
