using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFilters.Models;

namespace MVCFilters.Controllers
{
    public class HomeController : Controller
    {
        MVCDBEntities dc = new MVCDBEntities();
        public ViewResult DisplayDepts()
        {
            return View(dc.Departments);
        }

        [ChildActionOnly]
        public ViewResult DisplayEmpsByDept(int Did)
        {
            var Emps = from E in dc.Employees where E.Did == Did select E;
            return View(Emps);
        }
    }
}