using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_DB_FirstDemo.Models;

namespace EF_DB_FirstDemo.Controllers
{
    public class DepartmentController : Controller
    {
        CDO22DN005Entities entities;
        // GET: Department
        public DepartmentController()
        {
                entities = new CDO22DN005Entities();
        }
        [HttpGet]
        public ActionResult Index()
        {
            entities.Departments.ToList();

            return View(entities.Departments.ToList());
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
          var dept=  entities.Departments.Find(id);

            return View(dept);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department department)
        {
            if(ModelState.IsValid)
            {
                entities.Departments.Add(department);
                entities.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var department = entities.Departments.Find(id);
            return View(department);
        }
        [HttpPost]
        public ActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {entities.Entry(department).State=System.Data.Entity.EntityState.Modified;
                entities.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
           Department department = entities.Departments.Find(id);
            return View(department);
        }
      //  [HttpPost,ActionName("Delete")]
      [HttpPost]
      [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Department department = entities.Departments.Find(id);
            entities.Departments.Remove(department);
                entities.SaveChanges();
           
            return RedirectToAction("Index");
        }
    }
}