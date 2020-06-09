using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestPageNorth.Models;

namespace TestPageNorth.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult List()
        {
            ViewBag.Mensaje = "Bienvenido a la lista de clientes";
            return View();
        }

        [HttpPost]
        public ActionResult List(CustomersVM model)
        {
            DataAccess.NORTHWNDEntities entities = new DataAccess.NORTHWNDEntities();
            var customerQry = entities.Customers.AsQueryable();
            if (!string.IsNullOrWhiteSpace(model.SearchText))
            {
                customerQry = customerQry.Where(w => w.ContactName.Contains(model.SearchText) || w.Phone.Contains(model.SearchText));
            }


            model.Customers = customerQry.Select(cust => new CustometItemVM
            {
                Company = cust.CompanyName,
                Address = cust.Address + " " + cust.City + " " + cust.Country,
                Phone = cust.Phone,
                CustomerName = cust.ContactName
            }).ToList();


            return View(model);
        }
    }
}