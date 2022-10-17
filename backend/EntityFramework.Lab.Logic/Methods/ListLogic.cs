using EntityFramework.Lab.Entities;
using EntityFramework.Lab.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.Logic
{
    public class ListLogic
    {
        public static void ListEmployees()
        {
            try
            {
                EmployeesLogic employees = new EmployeesLogic();

                foreach (Employees employee in employees.GetAll())
                {
                    Console.WriteLine($"{employee.EmployeeID} - Employee: {employee.LastName}, {employee.FirstName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }

        }
        public static void ListOrders()
        {
            try
            {
                OrdersLogic orders = new OrdersLogic();

                foreach (Orders order in orders.GetAll())
                {
                    Console.WriteLine($"{order.OrderID}, {order.ShipAddress}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }
        }
        public static void ListCustomer()
        {
            try
            {
                CustomersLogic customerLogic = new CustomersLogic();

                foreach (Customers customer in customerLogic.GetAll())
                {
                    Console.WriteLine($"{customer.CustomerID}, {customer.CompanyName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }

        }
        public static void ListShipper()
        {
            try
            {
                ShippersLogic shipperLogic = new ShippersLogic();

                foreach (Shippers shipper in shipperLogic.GetAll())
                {
                    Console.WriteLine($"{shipper.ShipperID} - Company: {shipper.CompanyName} | Phone: {shipper.Phone}");
                }
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
