using EntityFramework.Lab.Entities;
using EntityFramework.Lab.Logic.Logic;
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

                Console.Write("Enter the name of employee: ");
                string name = Console.ReadLine();
                while (name == "")
                {
                    Console.Write("You must enter a name:\t");
                    name = Console.ReadLine();
                }
                employees.FirstName = name;              
                
                Console.Write("Enter the last name of employee: ");
                string lastName = Console.ReadLine();   
                while (lastName == "")
                {
                    Console.Write("You must enter a last name:\t");
                    lastName = Console.ReadLine();
                }
                employees.LastName = lastName;
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
                string adress = Console.ReadLine();
                while (adress == "")
                {
                    Console.Write("You must enter an adress:\t");
                    adress = Console.ReadLine();
                }
                orders.ShipAddress = adress;
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
                string nameCompany = Console.ReadLine();
                while (nameCompany == "")
                {
                    Console.Write("You must enter a name:\t");
                    nameCompany = Console.ReadLine();
                }
                shipper.CompanyName = nameCompany;

                Console.Write("Enter a phone number..");
                string phone = Console.ReadLine();
                while (phone == "")
                {
                    Console.Write("You must enter a phone number:\t");
                    phone = Console.ReadLine();
                }
                shipper.Phone = phone;


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
