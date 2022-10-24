using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Transport_App.Options;

namespace Transport_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OptionsMenu show = new OptionsMenu();
            int exit = 999;
            while (exit != 0)
            {

                try
                {
                    show.ShowMenu();
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            show.ShowTaxiMenu();                            
                            break;
                        case 2:
                            show.ShowBusMenu();
                            break;
                        case 3:
                            show.List();
                            break;
                        case 4:
                            Console.Clear();                          
                            exit = 0;
                            Console.WriteLine("Press enter to close terminal..");
                            break;
                        default:
                            Console.WriteLine("Select an option between 1 and 4...");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadKey();
        }
    }
}

