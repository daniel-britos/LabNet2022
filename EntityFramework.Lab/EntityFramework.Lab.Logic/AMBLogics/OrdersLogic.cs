using EntityFramework.Lab.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.Logic
{
    public class OrdersLogic : BaseLogic, ILogicABM<Orders>
    {
        public List<Orders> GetAll()
        {
            return _context.Orders.ToList();
        }
        public void Add(Orders newOrder)
        {
            _context.Orders.Add(newOrder);

            _context.SaveChanges();
        }
        public void Update(Orders order)
        {
            try
            {
                var orderUpdate = _context.Orders.Find(order.OrderID);

                orderUpdate.ShipAddress = order.ShipAddress;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Delete(int id)
        {
            var orderDelete = _context.Orders.Find(id);

            _context.Orders.Remove(orderDelete);

            _context.SaveChanges();
        }
        public void Search(int id)
        {            
            var employee = _context.Employees.Find(id);
            var orders = _context.Orders.Where(o => o.EmployeeID == id);
            Console.WriteLine($"Employee: {employee.LastName}, {employee.FirstName} | Quantity of orders: {orders.Count()}");
        }
    }
}
