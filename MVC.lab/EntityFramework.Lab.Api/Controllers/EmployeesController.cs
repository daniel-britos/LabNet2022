using EntityFramework.Lab.Api.Models;
using EntityFramework.Lab.Entities;
using EntityFramework.Lab.Logic;
using EntityFramework.Lab.Logic.AMBLogics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;

namespace EntityFramework.Lab.Api.Controllers
{
    public class EmployeesController : ApiController
    {
        EmployeesLogic eLogic = new EmployeesLogic();

        // GET: api/Employees
        public IHttpActionResult GetAll()
        {
            List<Employees> eList = eLogic.GetAll();
            List<EmployeesView> eView = eList.Select(employee => new EmployeesView
            {
                Id = employee.EmployeeID,
                Name = employee.FirstName,
                LastName = employee.LastName,
                Phone = employee.HomePhone
            }).ToList();

            if (eView.Count == 0)
            {
                return NotFound();
            }

            return Ok(eView);
        }

        // GET: api/Employees/{id}
        public IHttpActionResult GetEmployeeById(int id)
        {
            try
            {
                Employees employees = eLogic.Search(id);

                if (employees == null)
                {
                    return NotFound();
                }
                else
                {
                    EmployeesView eView = new EmployeesView
                    {
                        Id = employees.EmployeeID,
                        Name = employees.FirstName,
                        LastName = employees.LastName,
                        Phone = employees.HomePhone
                    };
                    return Ok(eView);
                }
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.NotFound, ex.Message);
            }
        }

        // POST: api/Employees
        public IHttpActionResult AddEmployee([FromBody]EmployeesView employeesView)
        {
            try
            {
                Employees employees = new Employees()
                {
                    EmployeeID = employeesView.Id,
                    FirstName = employeesView.Name,
                    LastName = employeesView.LastName,
                    HomePhone = employeesView.Phone
                };
                eLogic.Add(employees);
                return Content(HttpStatusCode.Created, employees);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        //localhost:44339//api/Employees
        [HttpPut] 
        public IHttpActionResult UpdateEmployee(EmployeesView employeesView)
        {
            try
            {
                Employees employee = new Employees()
                {
                    EmployeeID = employeesView.Id,
                    FirstName = employeesView.Name,
                    LastName = employeesView.LastName,   
                    HomePhone = employeesView.Phone
                };
                eLogic.Update(employee);

                return Ok("EMPLOYEE UPDATED");
            }
            catch (Exception)
            {
                return BadRequest("ERROR ATTEMPT.");
            }
        }

        // DELETE: api/Employees/{id}
        public IHttpActionResult DeleteEmployee(int id)
        {       
            try
            {
                eLogic.Delete(id);
                return Ok("EMPLOYEE DELETED.");
            }
            catch (Exception)
            {
                return BadRequest("ATTEMPT ERROR.");
            }
        }
    }
}