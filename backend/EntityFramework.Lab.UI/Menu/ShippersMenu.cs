using EntityFramework.Lab.Logic.Methods;
using EntityFramework.Lab.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.UI.Menu
{
    public class ShippersMenu
    {
        public static void Menu()
        {
            Console.WriteLine(
                "Press 1 to list shippers.\n" +
                "Press 2 to add an shipper.\n" +
                "Press 3 to update an shipper.\n" +
                "Press 4 to search an shipper.\n" +
                "Press 5 to delete an shipper.\n" +
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
                        Console.WriteLine("--- SHIPPER LIST");
                        ListLogic.ListShipper();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "2":
                        Console.Clear();
                        AddLogic.AddShipper();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "3":
                        Console.Clear();
                        UpdateLogic.UpdateShipper();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "4":
                        Console.Clear();
                        SearchLogic.SearchShipper();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "5":
                        Console.Clear();
                        DeleteLogic.DeleteShipper();
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
