using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPageNorth.Models
{
    public class CustomersVM
    {

        public string SearchText { get; set; }
        public CustomersVM()
        {
            Customers = new List<CustometItemVM>();
        }
        public List<CustometItemVM> Customers { get; set; }
    }

    public class CustometItemVM 
    {
        public string Company { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}