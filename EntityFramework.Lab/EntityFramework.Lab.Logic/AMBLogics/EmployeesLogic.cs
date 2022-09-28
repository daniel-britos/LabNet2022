using EntityFramework.Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.Logic
{
    public class EmployeesLogic : BaseLogic, ILogicABM<Employees>
    {
        public List<Employees> GetAll()
        {
            return _context.Employees.ToList();
        }
        public void Add(Employees newEmployee)
        {
            _context.Employees.Add(newEmployee);

            _context.SaveChanges();
        }
        public void Update(Employees employee)
        {
            try
            {
                var employeeUpdate = _context.Employees.Find(employee.EmployeeID);

                employeeUpdate.LastName = employee.LastName;
                employeeUpdate.FirstName = employee.FirstName;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
        }
        public void Delete(int id)
        {
            var employeeDelete = _context.Employees.Find(id);

            _context.Employees.Remove(employeeDelete);

            _context.SaveChanges();
        }
        public void Search(int id)
        {
            var employee = _context.Employees.Find(id);
            Console.WriteLine($"Employee {employee.LastName}, {employee.FirstName} found..");
        }
    }
}
