using MVCListwDatabase.Models;
using MVCListwDatabase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCListwDatabase.Controllers
{
    public class EmployeeController : Controller
    {
        NorthwindEntities _db;
        public EmployeeController()
        {
            _db= new NorthwindEntities();
        }
        // GET: Employee
        public ActionResult EmployeeList()
        {
            IndexVM ivm = new IndexVM
            {
                Employees = _db.Employees.ToList()
                
            };
            return View(ivm);
        }
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            _db.Employees.Add(employee);
            _db.SaveChanges();
            return RedirectToAction("EmployeeList");
        }
    }
}