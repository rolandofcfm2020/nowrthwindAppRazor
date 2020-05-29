using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPageNorth.Models
{
    public class EmployeesListVM
    {
        public EmployeesListVM()
        {
            Employees = new List<EmployeesItemVM>();
        }
        public List<EmployeesItemVM> Employees { get; set; }
        public string SearchText { get; set; }
    }

    public class EmployeesItemVM 
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string  Tittle { get; set; }
    }
}