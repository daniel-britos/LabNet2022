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
            try
            {
                _context.Employees.Add(newEmployee);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }
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
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var employeeDelete = _context.Employees.Find(id);

                _context.Employees.Remove(employeeDelete);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }
        }
        public void Search(int id)
        {
            try
            {
                var employee = _context.Employees.Find(id);
                Console.WriteLine($"Employee {employee.LastName}, {employee.FirstName} found..");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }
        }
    }
}
