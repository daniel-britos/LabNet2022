using LinQ.Lab.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ.Lab.UI.subMenu
{
    public class Menu
    {
        public static void ShowMenu()
        {
            ProductsLogic products = new ProductsLogic();
            CustomersLogic customers = new CustomersLogic();


            Console.WriteLine(
                "PANEL DE CONTROL PARA EJERCICIOS DE LINQ\n" +
                "Seleccione cuales ejercicios desea ver:\n" +
                "1. Ejercicios obligatorios.\n" +
                "2. Ejercicios opcionales.\n" +
                "0. Para salir.");

            var key = "66";

            while (key != "0")
            {
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.Clear();
                        RequiredTasksMenu.RequiredMenu();
                        break;
                    case "2":
                        Console.Clear();
                        OptionalTasksMenu.OptionalMenu();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Gracias por ver mi trabajo!!");
                        break;
                    default:
                        Console.WriteLine("ERROR!");
                        break;
                }
            }


        }
    }
}
