using EntityFramework.Lab.Entities;
using EntityFramework.Lab.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.Logic
{
    public class UpdateLogic
    {
        public static void UpdateEmployees() 
        {
            try
            {
                EmployeesLogic employees = new EmployeesLogic();

                foreach (Employees emp in employees.GetAll())
                {
                    Console.WriteLine($"{emp.EmployeeID} - Employee: {emp.LastName}, {emp.FirstName}");
                }
                Employees employee = new Employees();
                Console.WriteLine("Enter an ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                employee.EmployeeID = id;
                Console.WriteLine("Enter a new name:");
                string name = Console.ReadLine();
                employee.FirstName = name;
                Console.WriteLine("Enter a new last name:");
                string lastName = Console.ReadLine();
                employee.LastName = lastName;

                EmployeesLogic employeesLogic = new EmployeesLogic();
                employeesLogic.Update(employee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }          
        }
        public static void UpdateOrder()
        {
            try
            {
                OrdersLogic ordersLogic = new OrdersLogic();
                foreach (Orders or in ordersLogic.GetAll())
                {
                    Console.WriteLine($"Order Number: {or.OrderID}, {or.ShipAddress}");
                }

                Orders order = new Orders();
                Console.WriteLine("Enter an order number..");
                int id = Convert.ToInt32(Console.ReadLine());
                order.OrderID = id;
                Console.WriteLine("Enter a new adress:");
                string name = Console.ReadLine();
                order.ShipAddress = name;
                Console.WriteLine("Updated order..");
                ordersLogic.Update(order);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }
        }
        public static void UpdateShipper()
        {
            try
            {
                ShippersLogic shipperLogic = new ShippersLogic();

                foreach (Shippers shipp in shipperLogic.GetAll())
                {
                    Console.WriteLine($"{shipp.ShipperID} - Company: {shipp.CompanyName} | Phone: {shipp.Phone}");
                }

                Shippers shipper = new Shippers();
                Console.WriteLine("Enter shipper ID");
                int id = Convert.ToInt32(Console.ReadLine());
                shipper.ShipperID = id;
                Console.WriteLine("Enter a new company name:");
                string name = Console.ReadLine();
                shipper.CompanyName = name;
                Console.WriteLine("Enter a new phone:");
                string phone = Console.ReadLine();
                shipper.Phone = phone;

                ShippersLogic shipperLogics = new ShippersLogic();
                shipperLogics.Update(shipper);
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
