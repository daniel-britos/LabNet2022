using LinQ.Lab.Entities;
using LinQ.Lab.Logic;
using LinQ.Lab.Logic.ShowLogic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinQ.Lab.UI.subMenu
{
    public class OptionalTasksMenu
    {
        public static void OptionalMenu()
        {
            ProductsLogic products = new ProductsLogic();
            CustomersLogic customers = new CustomersLogic();

            Console.WriteLine(
                "Lista de ejercicios opcionales:\n" +
                "Pres 8 para ver -> 8). Query para devolver los primeros 3 Customers de la  Región WA.\n" +
                "Pres 9 para ver -> 9). Query para devolver lista de productos ordenados por nombre.\n" +
                "Pres 10 para ver -> 10). Query para devolver lista de productos ordenados por unit in stock de mayor a menor.\n" +
                "Pres 11 para ver -> 11). Query para devolver las distintas categorías asociadas a los productos.\n" +
                "Pres 12 para ver -> 12). Query para devolver el primer elemento de una lista de productos.\n" +
                "Pres 13 para ver -> 13). Query para devolver los customer con la cantidad de ordenes asociadas.\n" +                
                "Pres L para ver la lista completa de productos.\n" +
                "Pres E si desea salir.");


            var key = "77";

            while (key != "0")
            {
                try
                {
                    key = Console.ReadLine();
                    switch (key.ToUpper())
                    {
                        case "8":
                            Console.Clear();
                            Console.WriteLine("8. Query para devolver los primeros 3 Customers de la  Región WA:");
                            ShowLogic.Exercise8();
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine();
                            Menu.ShowMenu();
                            break;
                        case "9":
                            Console.Clear();
                            Console.WriteLine("Query para devolver lista de productos ordenados por nombre:");
                            ShowLogic.Exercise9();
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine();
                            Menu.ShowMenu();
                            break;
                        case "10":
                            Console.Clear();
                            Console.WriteLine("10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor:");
                            ShowLogic.Exercise10();
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine();
                            Menu.ShowMenu();
                            break;
                        case "11":
                            Console.Clear();
                            Console.WriteLine("11. Query para devolver las distintas categorías asociadas a los productos.");
                            ShowLogic.Exercise11();
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine();
                            Menu.ShowMenu();
                            break;
                        case "12":
                            Console.Clear();
                            Console.WriteLine("12. Query para devolver el primer elemento de una lista de productos:");
                            ShowLogic.Exercise12();
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine();
                            Menu.ShowMenu();
                            break;
                        case "13":
                            Console.Clear();
                            Console.WriteLine("13. Query para devolver los customer con la cantidad de ordenes asociadas:");
                            ShowLogic.Exercise13();
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine();
                            Menu.ShowMenu();
                            break;
                        case "L":
                            Console.WriteLine("--- LISTA PRODUCTOS");
                            ShowLogic.List();
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine();
                            Menu.ShowMenu();
                            break;
                        case "E":
                            Console.Clear();
                            Console.WriteLine("Gracias por ver mi trabajo!!...");
                            break;
                        default:
                            Console.WriteLine("ERROR!");
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Ingresó mal los datos...");

                }
            }
        }
    }
}

