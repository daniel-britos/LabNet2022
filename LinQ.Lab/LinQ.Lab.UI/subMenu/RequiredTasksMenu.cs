using LinQ.Lab.Entities;
using LinQ.Lab.Logic;
using LinQ.Lab.Logic.ShowLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ.Lab.UI.subMenu
{
    public class RequiredTasksMenu
    {
        
        public static void RequiredMenu()
        {
            ProductsLogic products = new ProductsLogic();
            CustomersLogic customers = new CustomersLogic();

            Console.WriteLine(
                "Lista de ejercicios obligatorios:\n" +
                "Pres 1 para ver -> 1). Query para devolver objeto customer\n" +
                "Pres 2 para ver -> 2). Query para devolver todos los productos sin stock\n" +
                "Pres 3 para ver -> 3). Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad\n" +
                "Pres 4 para ver -> 4). Query para devolver todos los customers de la Región WA\n" +
                "Pres 5 para ver -> 5). Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789\n" +
                "Pres 6 para ver -> 6). Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.\n" +
                "Pres 7 para ver -> 7). Query para devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1/1/1997.\n" +
                "Pres L para ver la lista completa de productos.\n" +
                "Pres E si desea salir.");


            var key = "77";

            while (key!="0")
            {
                try
                {
                    key = Console.ReadLine();
                    switch (key.ToUpper())
                    {
                        case "1":
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("1. Query para devolver objeto customer");                                
                                Console.WriteLine("Escriba una de las siguientes opciones: ");
                                Console.WriteLine(
                                                    "ALFKI\n" +
                                                    "ANATR\n" +
                                                    "ANTON"
                                                    );

                                ShowLogic.Exercise1();
                                Console.WriteLine("---------------------------------------------");
                                Console.WriteLine();
                                Menu.ShowMenu();
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Debió ingresar una de las opciiones..");
                                Console.WriteLine("---------------------------------------------");
                                Console.WriteLine();
                                Menu.ShowMenu();
                            }
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("2. Productos sin stock:");
                            ShowLogic.Exercise2();
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine();
                            Menu.ShowMenu();
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("3. En stock, precio mayor a 3:");
                            ShowLogic.Exercise3();
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine();
                            Menu.ShowMenu();
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("4. Customers región WA:");
                            ShowLogic.Exercise4();
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine();
                            Menu.ShowMenu();
                            break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine("5. Primer elemento o nulo en lista de productos:");
                            ShowLogic.Exercise5();
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine();
                            Menu.ShowMenu();
                            break;
                        case "6":
                            Console.Clear();
                            Console.WriteLine("6. Nombres de los customers en mayuscula y minuscula:");
                            ShowLogic.Exercise6();
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine();
                            Menu.ShowMenu();
                            break;
                        case "7":
                            Console.Clear();
                            Console.WriteLine("7. Join entre customers y orders, customers región WA con fecha mayor a 1997/1/1:");
                            ShowLogic.Exercise7();
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine();
                            Menu.ShowMenu();
                            break;
                        case "L":
                            Console.WriteLine("--- LISTA");
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
