using EntityFramework.Lab.Logic.Methods;
using EntityFramework.Lab.Logic;
using EntityFramework.Lab.UI.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.UI
{
    public class EmployeesMenu
    {
        public static void Menu()
        {
            Console.WriteLine(
                "Press 1 to list employees.\n" +
                "Press 2 to add an employee.\n" +
                "Press 3 to update an employee.\n" +
                "Press 4 to delete an employee.\n" +
                "Press 5 to search an employee.\n" +
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
                        Console.WriteLine("--- EMPLOYEES LIST");
                        ListLogic.ListEmployees();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "2":
                        Console.Clear();
                        AddLogic.AddEmployee();
                        Console.WriteLine("Added employee..");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "3":
                        Console.Clear();
                        UpdateLogic.UpdateEmployees();
                        Console.WriteLine("Updated employee..");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "4":
                        Console.Clear();
                        DeleteLogic.DeleteEmployee();
                        Console.WriteLine("Deleted employee..");
                        Console.WriteLine("Employee deleted..");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press another option..");
                        Menu();
                        break;
                    case "5":
                        Console.Clear();                        
                        SearchLogic.SearchEmployee();
                        Console.WriteLine("Employee found..");
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
