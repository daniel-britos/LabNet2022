using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_App.Options
{
    public class OptionsMenu
    {
        List<PublicTransport> Transports = new List<PublicTransport>();
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---- WELCOME TO THE TRANSPORTATION WIZARD -----");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose one of the options:\n" +
                              "Press 1 to add taxi\n" +
                              "Press 2 to add Bus\n" +
                              "Press 3 to list\n" +
                              "Press 4 to Exit");
        }

        public void ShowTaxiMenu()
        {
            try
            {
                int taxiNumber = 0;
                while (taxiNumber < 5)
                {
                    taxiNumber++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"How many passengers traveling in taxi number {taxiNumber}?");
                    int passenger = Convert.ToInt32(Console.ReadLine());
                    if (passenger > 4 || passenger < 0)
                    {
                        taxiNumber--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a valid number for the type of transport (0 to 4).");
                    }
                    else
                    {
                        Transports.Add(new Taxi(passenger, "Taxi"));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("<Formato incorrecto> ");
                Console.Write(ex.Message);
                Console.Write("\n");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
    
        public void ShowBusMenu()
        {
            try
            {
                int busNumber = 0;
                while (busNumber < 5)
                {
                    busNumber++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"How many passengers traveling in the bus number {busNumber}?");
                    int passenger = Convert.ToInt32(Console.ReadLine());
                    if (passenger > 30 || passenger < 0)
                    {
                        busNumber--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a valid number for the type of transport (0 to 30).");
                    }
                    else
                    {
                        Transports.Add(new Bus(passenger, "Bus"));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("<Formato incorrecto> ");
                Console.Write(ex.Message);
                Console.Write("\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    
        public void List()
        {
            Console.Clear();
            Console.WriteLine("----- List ------");
            foreach (var item in Transports)
            {
                Console.WriteLine($"Passengers: {item.Passengers} | Transport: {item.Type}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
