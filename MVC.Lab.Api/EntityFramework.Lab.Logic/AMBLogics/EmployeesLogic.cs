using EntityFramework.Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            var employeeUpdate = _context.Employees.Find(employee.EmployeeID);
            try
            {
                employeeUpdate.LastName = employee.LastName;
                employeeUpdate.FirstName = employee.FirstName;
                employeeUpdate.HomePhone = employee.HomePhone;
                _context.SaveChanges();
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
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
                throw new Exception(ex.Message);
            }
        }
        public Employees Search(int id)
        {
            return _context.Employees.Find(id);
        }
    }
}
