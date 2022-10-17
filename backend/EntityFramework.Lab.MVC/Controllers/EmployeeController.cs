using EntityFramework.Lab.Entities;
using EntityFramework.Lab.Logic;
using EntityFramework.Lab.Logic.Logic;
using EntityFramework.Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace EntityFramework.Lab.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeesLogic eLogic = new EmployeesLogic();
        // GET: Employees
        public ActionResult Index()
        {
            List<Employees> employees = eLogic.GetAll();

            List<EmployeeView> employeesView = employees.Select(s => new EmployeeView
            {
                Id = s.EmployeeID,
                Name = s.FirstName,
                LastName = s.LastName,
                Phone = s.HomePhone
            }).ToList();
            return View(employeesView);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeView employeesView)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                var emp = new Employees
                {
                    FirstName = employeesView.Name,
                    LastName = employeesView.LastName,
                    HomePhone = employeesView.Phone
                };
                eLogic.Add(emp);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            try
            {
                Employees employee = eLogic.Search(id);
                EmployeeView employeesView = new EmployeeView
                {
                    Id = employee.EmployeeID,
                    Name = employee.FirstName,
                    LastName = employee.LastName,
                    Phone = employee.HomePhone
                };
                return View(employeesView);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        [HttpPost]
        public ActionResult Update(EmployeeView employeeView)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                var emp = new Employees
                {
                    EmployeeID = employeeView.Id,
                    FirstName = employeeView.Name,
                    LastName = employeeView.LastName,
                    HomePhone = employeeView.Phone
                };
                eLogic.Update(emp);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
        public ActionResult Delete(int id)
        {
            try
            {
                eLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}


