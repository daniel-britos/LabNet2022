using EntityFramework.Lab.Entities;
using EntityFramework.Lab.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.Logic
{
    public class DeleteLogic
    {
        public static void DeleteEmployee()
        {
            try
            {
                EmployeesLogic employeeLogic = new EmployeesLogic();

                foreach (Employees employee in employeeLogic.GetAll())
                {
                    Console.WriteLine($"{employee.EmployeeID} - Employee: {employee.LastName}, {employee.FirstName}");
                }
                Console.WriteLine();
                Console.WriteLine("Enter an ID to delete employee..");
                int deleteId = Convert.ToInt32(Console.ReadLine());

                employeeLogic.Delete(deleteId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }          
        }
        public static void DeleteOrder()
        {
            try
            {
                OrdersLogic ordersLogic = new OrdersLogic();

                foreach (Orders order in ordersLogic.GetAll())
                {
                    Console.WriteLine($"{order.OrderID}, {order.ShipAddress}");
                }
                Console.WriteLine();
                Console.WriteLine("Enter an ID between 10248 to 11078 or check list to delete order..");
                int deleteId = Convert.ToInt32(Console.ReadLine());
                ordersLogic.Delete(deleteId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }           
        }
        public static void DeleteShipper()
        {        
            try
            {
                ShippersLogic shipperLogic = new ShippersLogic();

                foreach (Shippers shipper in shipperLogic.GetAll())
                {
                    Console.WriteLine($"{shipper.ShipperID} - Company: {shipper.CompanyName} | Phone: {shipper.Phone}");
                }
                Console.WriteLine();
                Console.WriteLine("Enter the ID of the shipper to delete.");
                int deleteId = Convert.ToInt32(Console.ReadLine());
                shipperLogic.Delete(deleteId);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }
         
        }
    }
}
