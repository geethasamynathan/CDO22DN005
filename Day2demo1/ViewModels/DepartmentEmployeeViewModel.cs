using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Day2demo1.Models;

namespace Day2demo1.ViewModels
{
    public class DepartmentEmployeeViewModel
    {
        public Employee Employee { get; set; }
        public Department Department { get; set; }
        public string Title { get; set; }
    }
}