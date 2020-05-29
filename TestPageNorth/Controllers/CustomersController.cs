using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}