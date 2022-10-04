using EntityFramework.Lab.Logic.Methods;
using EntityFramework.Lab.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.UI.Menu
{
    public class OrdersMenu
    {
        public static void Menu()
        {
            Console.WriteLine(
                "Press 1 to list orders.\n" +
                "Press 2 to add an order.\n" +
                "Press 3 to update an order.\n" +
                "Press 4 to delete an order.\n" +
                "Press 5 to see the number of orders per employee.\n" +
                "Press 6 to EXIT."
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
                        Console.WriteLine("--- ORDERS LIST");
                        ListLogic.ListOrders();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "2":
                        Console.Clear();
                        AddLogic.AddOrder();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "3":
                        Console.Clear();
                        UpdateLogic.UpdateOrder();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "4":
                        Console.Clear();
                        DeleteLogic.DeleteOrder();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "5":
                        Console.Clear();
                        SearchLogic.SearchOrder();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "6":
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
