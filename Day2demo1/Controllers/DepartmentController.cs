using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2demo1.Models;

namespace Day2demo1.Controllers
{
    public class DepartmentController : Controller
    {
        List<Department> departmentList;
        public DepartmentController()
        {
            departmentList = new List<Department>() { 
            new Department{Id=101,Name="IT",Location="Bangalore" },
            new Department {Id=102,Name="Transport",Location="Mysore"}
            
            };

        }
        // GET: Department
        //public string Index()
        //{
        //    return "Hello world";
        //}

        public ActionResult Index()
        {
            return View();
        }
        /// example fro ViewData

        public ActionResult Getdepartments()
        {
            //     ViewData["deptnames"] = "Information Technology";
            List<string> departments = new List<string>();
            departments.Add("IT");
            departments.Add("HR");
            departments.Add("Admin");
            ViewData["depts"] = departments;
            return View();
        }

        public ActionResult GetDepts()
        {
            /*   ViewBag.deptname = "Huma resource";
             *   */
            List<string> Gencs = new List<string>();
            Gencs.Add("Vandana");
            Gencs.Add("Amey");
            Gencs.Add("Anvesh");
            ViewBag.Gencs = Gencs;
            return View();
        }

        public ActionResult GetAllDepartments()
        {
           
            return View(departmentList);
        }

        public ActionResult GetAll()
        {
            ViewBag.alldepts = departmentList;
            return View();
        }
    }
}