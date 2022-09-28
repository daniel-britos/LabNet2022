using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFramework.Lab.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Lab.Logic.AMBLogics;
using EntityFramework.Lab.Entities;

namespace EntityFramework.Lab.Logic.Tests
{
    [TestClass()]
    public class EmployeesLogicTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //ARRAGE
            EmployeesLogic employeeLogic = new EmployeesLogic();  
            Employees employees = new Employees();
            employees.FirstName = "Daniel"; 
            employees.LastName = "Britos";

            //ACT
            employeeLogic.Add(employees);

            //ASSERT
            List<Employees> empList = employeeLogic.GetAll().ToList();
            Employees emps = empList[empList.Count() - 1]; 
            Assert.AreEqual(employees, emps);  
        }
    }
}