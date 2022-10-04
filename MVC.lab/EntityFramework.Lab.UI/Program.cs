using EntityFramework.Lab.Entities;
using EntityFramework.Lab.Logic;
using EntityFramework.Lab.Logic.Methods;
using EntityFramework.Lab.UI.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            //MENU            
            bool exit = false;
            do
            {
                GeneralMenu.Menu();
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        EmployeesMenu.Menu();
                        EmployeesMenu.ActionsMenu();
                        break;
                    case "2":
                        Console.Clear();
                        OrdersMenu.Menu();
                        OrdersMenu.ActionsMenu();
                        break;
                    case "3":
                        Console.Clear();
                        CustomersMenu.Menu();
                        CustomersMenu.ActionsMenu();
                        break;
                    case "4":
                        Console.Clear();
                        ShippersMenu.Menu();
                        ShippersMenu.ActionsMenu();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Press enter to close...");
                        exit = true;
                        break;
                    default:
                        break;
                }

            } while (!exit);
            Console.ReadKey();
        }
    }
}
