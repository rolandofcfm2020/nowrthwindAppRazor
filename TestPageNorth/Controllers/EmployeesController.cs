using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using TestPageNorth.Models;

namespace TestPageNorth.Controllers
{
    public class EmployeesController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Index(EmployeesListVM employees)
        {
            DataAccess.NORTHWNDEntities entities = new DataAccess.NORTHWNDEntities();
            var allEmployeesQry = entities.Employees.AsQueryable();

            if (!string.IsNullOrEmpty(employees.SearchText))
            {
                allEmployeesQry = allEmployeesQry.Where(W => W.FirstName.Contains(employees.SearchText)).AsQueryable();
            }

            var employeeList = allEmployeesQry.Select(s => new EmployeesItemVM
            {
                Name = s.FirstName,
                Telephone = s.HomePhone,
                Tittle = s.Title,
            }).ToList();

            employees.Employees = employeeList;

            return View(employees);
        }
    }
}
