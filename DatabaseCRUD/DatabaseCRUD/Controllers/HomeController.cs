using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseCRUD.Models;

namespace DatabaseCRUD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployees()
        {
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var employee = dc.Employees.OrderBy(a => a.FirstName).ToList();
                return Json(new { data = employee }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}