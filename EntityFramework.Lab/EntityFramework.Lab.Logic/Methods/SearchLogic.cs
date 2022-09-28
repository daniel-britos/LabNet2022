using EntityFramework.Lab.Entities;
using EntityFramework.Lab.Logic.AMBLogics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.Logic.Methods
{
    public class SearchLogic
    {
        public static void SearchEmployee()
        {
            try
            {
                Console.WriteLine("Enter the employee id to display it..");
                int employeeId = Convert.ToInt32(Console.ReadLine());

                EmployeesLogic employeeLogic = new EmployeesLogic();
                employeeLogic.Search(employeeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }             
        }
        public static void SearchOrder()
        {
            try
            {
                ListLogic.ListEmployees();
                Console.WriteLine("Enter the id of the employee to know the number of orders he has..");
                var orderId = Convert.ToInt32(Console.ReadLine());

                OrdersLogic orderLogic = new OrdersLogic();
                orderLogic.Search(orderId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter");
                Console.ReadKey(true);
            }                     
        }
        public static void SearchShipper()
        {
            try
            {
                ShippersLogic shipperLogic = new ShippersLogic();

                foreach (Shippers shipper in shipperLogic.GetAll())
                {
                    Console.WriteLine($"{shipper.ShipperID} - Company: {shipper.CompanyName} | Phone: {shipper.Phone}");
                }
                Console.WriteLine("Enter the shipper ID..");
                var shipperId = Convert.ToInt32(Console.ReadLine());

                shipperLogic.Search(shipperId);
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
