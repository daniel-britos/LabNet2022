using EntityFramework.Lab.Api.Models;
using EntityFramework.Lab.Entities;
using EntityFramework.Lab.Logic;
using EntityFramework.Lab.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;

namespace EntityFramework.Lab.Api.Controllers
{
    public class EmployeesController : ApiController
    {
        EmployeesLogic eLogic = new EmployeesLogic();

        /// <summary>
        /// Return a list of employees
        /// </summary>
        /// <returns>Employees list</returns>
        // GET: api/Employees
        [ResponseType(typeof(EmployeesView))]
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

        /// <summary>
        /// Returns an element by ID.
        /// </summary>
        /// <param name="id">ID del empleado.</param>
        /// <returns>Employee</returns>
        /// <response code="200">Found item..</response>
        /// <response code="404">Not Found encontrado.</response>
        // GET: api/Employees/{id}
        [ResponseType(typeof(EmployeesView))]
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

        /// <summary>
        /// Add an employee to the lis
        /// </summary>
        /// <param name="employeesView"></param>
        /// <returns>Employee created</returns>
        // POST: api/Employees
        [ResponseType(typeof(EmployeesView))]
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

        /// <summary>
        /// Update an employee from the list.
        /// </summary>
        /// <param name="employeesView"></param>
        /// <returns>Employee updated.</returns>        
        [HttpPut]
        [ResponseType(typeof(EmployeesView))]
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

        /// <summary>
        /// Remove an employee from the list.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Employee deleted.</returns>
        // DELETE: api/Employees/{id}
        [ResponseType(typeof(EmployeesView))]
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