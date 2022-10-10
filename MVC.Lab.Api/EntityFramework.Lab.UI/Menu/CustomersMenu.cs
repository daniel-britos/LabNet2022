using EntityFramework.Lab.Logic.Methods;
using EntityFramework.Lab.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.UI.Menu
{
    public class CustomersMenu
    {
        public static void Menu()
        {
            Console.WriteLine(
                "Press 1 to list customers.\n" +
                "Press 2 to EXIT."
            );
        }
        public static void ActionsMenu()
        {
            bool exit = false;
            do
            {
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("--- CUSTOMER LIST");
                        ListLogic.ListCustomer();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Press enter to return to de menu...");
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
