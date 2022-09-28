using EntityFramework.Lab.Entities;
using EntityFramework.Lab.Logic.AMBLogics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.Logic
{
    public class AddLogic
    {
        public static void AddEmployee()
        {
            try
            {
                Employees employees = new Employees();
                Console.Write("Enter the name of the employee: ");
                employees.FirstName = Console.ReadLine();
                Console.Write("Enter the last name of the employee: ");
                employees.LastName = Console.ReadLine();
                EmployeesLogic employeesLogic = new EmployeesLogic();
                employeesLogic.Add(employees);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }         
        }
        public static void AddOrder()
        {
            try
            {
                Orders orders = new Orders();
                Console.Write("Enter an address for your order..");
                orders.ShipAddress = Console.ReadLine();
                OrdersLogic ordersLogic = new OrdersLogic();
                ordersLogic.Add(orders);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }          
        }
        public static void AddShipper()
        {
            try
            {
                Shippers shipper = new Shippers();
                Console.Write("Enter a name for company shipper..");
                shipper.CompanyName = Console.ReadLine();
                Console.Write("Enter a phone number..");
                shipper.Phone = Console.ReadLine();
                ShippersLogic shipperLogic = new ShippersLogic();
                shipperLogic.Add(shipper);
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
