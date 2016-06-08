using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EditableGrid.Models;

namespace EditableGrid.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Default Method 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Action Method to Get Employee Details
        /// </summary>
        /// <returns></returns>
        public JsonResult GetEmployees()
        {
            List<Employee> empList = new List<Employee>();

            Employee emp = new Employee { FirstName = "James", LastName = "Bond", Country = "Germany" };
            empList.Add(emp);

            emp = new Employee { FirstName = "Roy", LastName = "Agasthyan", Country = "United States" };
            empList.Add(emp);

            return Json(new { employees = empList });
        }
    }
}
