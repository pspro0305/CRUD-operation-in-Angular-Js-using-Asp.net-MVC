using AngularCRUDPrakhar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularCRUDPrakhar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // Get all the employees added on page load.
        public JsonResult getAll()
        {
            using (AngularCRUDEntities dataContext = new AngularCRUDEntities())
            {
                var employeeList = dataContext.M_Employee.ToList();
                return Json(employeeList, JsonRequestBehavior.AllowGet);
            }
        }

        // Get Specific employee by their ID.
        public JsonResult getEmployeeByNo(string EmpNo)
        {
            using (AngularCRUDEntities dataContext = new AngularCRUDEntities())
            {
                int no = Convert.ToInt32(EmpNo);
                var employeeList = dataContext.M_Employee.Find(no);
                return Json(employeeList, JsonRequestBehavior.AllowGet);
            }
        }

        // Update Specific employee by their ID.
        public string UpdateEmployee(M_Employee Emp)
        {
            if (Emp != null)
            {
                using (AngularCRUDEntities dataContext = new AngularCRUDEntities())
                {
                    int no = Convert.ToInt32(Emp.Id);
                    var employeeList = dataContext.M_Employee.Where(x => x.Id == no).FirstOrDefault();
                    employeeList.name = Emp.name;
                    employeeList.mobileno = Emp.mobileno;
                    employeeList.email = Emp.email;
                    dataContext.SaveChanges();
                    return "Employee Updated";
                }
            }
            else
            {
                return "Invalid Employee";
            }
        }

        // Add new employee to db.
        public string AddEmployee(M_Employee Emp)
        {
            if (Emp != null)
            {
                using (AngularCRUDEntities dataContext = new AngularCRUDEntities())
                {
                    dataContext.M_Employee.Add(Emp);
                    dataContext.SaveChanges();
                    return "Employee Updated";
                }
            }
            else
            {
                return "Invalid Employee";
            }
        }

        // Delete Specific employee by their ID.
        public string DeleteEmployee(M_Employee Emp)
        {
            if (Emp != null)
            {
                using (AngularCRUDEntities dataContext = new AngularCRUDEntities())
                {
                    int no = Convert.ToInt32(Emp.Id);
                    var employeeList = dataContext.M_Employee.Where(x => x.Id == no).FirstOrDefault();
                    dataContext.M_Employee.Remove(employeeList);
                    dataContext.SaveChanges();
                    return "Employee Deleted";
                }
            }
            else
            {
                return "Invalid Employee";
            }
        }

    }
}