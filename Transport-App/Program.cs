using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taxi firstTaxi = new Taxi(0, "NVZ 087");
            Taxi secondTaxi = new Taxi(0, "AB 123 CD");
            Taxi thirdTaxi = new Taxi(0, "LUD 152");
            Taxi fourthTaxi = new Taxi(0, "MLU 724");
            Taxi fifthTaxi = new Taxi(0, "XJY 024");

            Bus firstBus = new Bus(0, 113);
            Bus secondBus = new Bus(0, 124);
            Bus thirdBus = new Bus(0, 136);
            Bus fourthBus = new Bus(0, 2);
            Bus fifthBus = new Bus(0, 55);



            bool exit = false;

            while (!exit)
            {

                try 
                {
                    Console.WriteLine("---- WELCOME TO THE TRANSPORTATION WIZARD -----");
                    Console.WriteLine("Choose one of the options:\n" +
                                      "Press 1 to add taxi\n" +
                                      "Press 2 to add Bus\n" +
                                      "Press 3 to list\n" +
                                      "4. Exit"); 
                    
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            //list taxis
                            Console.Clear();
                            Console.WriteLine("Enter the number of passengers in the first taxi in the space below.");
                            int taxiOne = Int32.Parse(Console.ReadLine());
                            if (taxiOne > 4 || taxiOne <= 0)
                            {
                                Console.WriteLine("Only numbers between 1 and 4, try again");
                                taxiOne = Int32.Parse(Console.ReadLine());
                                firstTaxi.AddPassenger(taxiOne);
                            }
                            else
                            {
                                firstTaxi.AddPassenger(taxiOne);
                            }


                            Console.WriteLine("Enter the number of passengers in the second taxi in the space below.");
                            int taxiTwo = Int32.Parse(Console.ReadLine());
                            if (taxiTwo > 4 || taxiTwo <= 0)
                            {
                                Console.WriteLine("Only numbers between 1 and 4");
                                taxiTwo = Int32.Parse(Console.ReadLine());
                                secondTaxi.AddPassenger(taxiTwo);
                            }
                            else
                            {
                                secondTaxi.AddPassenger(taxiTwo);
                            }                               
                                                                                    
                            Console.WriteLine("Enter the number of passengers in the third taxi in the space below.");
                            int taxiThree = Int32.Parse(Console.ReadLine());
                            if (taxiThree > 4 || taxiThree <= 0)
                            {
                                Console.WriteLine("Only numbers between 1 and 4");
                                taxiThree = Int32.Parse(Console.ReadLine());
                                thirdTaxi.AddPassenger(taxiThree);
                            }
                            else
                            {
                                thirdTaxi.AddPassenger(taxiThree);
                            }
                                                                                                                                              
                            Console.WriteLine("Enter the number of passengers in the fourth taxi in the space below.");
                            int taxiFour = Int32.Parse(Console.ReadLine());
                            if (taxiFour > 4 || taxiFour <= 0)
                            {
                                Console.WriteLine("Only numbers between 1 and 4");
                                taxiFour = Int32.Parse(Console.ReadLine());
                                fourthTaxi.AddPassenger(taxiFour);
                            }
                            else
                            {
                                fourthTaxi.AddPassenger(taxiFour);
                            }
                                                                                                                                             
                            Console.WriteLine("Enter the number of passengers in the fifth taxi in the space below.");
                            int taxiFive = Int32.Parse(Console.ReadLine());
                            if (taxiFive > 4 || taxiFive <= 0)
                            {

                                Console.WriteLine("Only numbers between 1 and 4");
                                taxiFive = Int32.Parse(Console.ReadLine());
                                fifthTaxi.AddPassenger(taxiFive);
                            }
                            else
                            {
                                fifthTaxi.AddPassenger(taxiFive);                                                                                                                                              
                            }
                            Console.WriteLine("");
                            break;
                        case 2:                  
                            //list Bus
                            Console.Clear();
                            Console.WriteLine("Enter the number of passengers in the first bus in the space below.");
                            int busOne = Int32.Parse(Console.ReadLine());
                            if (busOne > 30 || busOne <= 0)
                            {
                                Console.WriteLine("Only numbers between 1 and 30");
                                busOne = Int32.Parse(Console.ReadLine());
                                firstBus.AddPassenger(busOne);
                            }
                            else
                            {
                                firstBus.AddPassenger(busOne);
                            }
                            
                            Console.WriteLine("Enter the number of passengers in the second bus in the space below.");
                            int busTwo = Int32.Parse(Console.ReadLine());
                            if (busTwo > 30 || busTwo <= 0)
                            {
                                Console.WriteLine("Only numbers between 1 and 30");
                                busTwo = Int32.Parse(Console.ReadLine());
                                secondBus.AddPassenger(busTwo);
                            }
                            else
                            {
                                secondBus.AddPassenger(busTwo);                                                                                                            
                            }

                            Console.WriteLine("Enter the number of passengers in the third bus in the space below.");
                            int busThree = Int32.Parse(Console.ReadLine());
                            if (busThree > 30 || busThree <= 0)
                            {
                                Console.WriteLine("Only numbers between 1 and 30");
                                busThree = Int32.Parse(Console.ReadLine());
                                thirdBus.AddPassenger(busThree);
                            }
                            else
                            {
                                thirdBus.AddPassenger(busThree);
                            }
                                                                                    
                            Console.WriteLine("Enter the number of passengers in the fourth bus in the space below.");
                            int busFour = Int32.Parse(Console.ReadLine());
                            if (busFour > 30 || busFour <= 0)
                            {
                                Console.WriteLine("Only numbers between 1 and 30");
                                busFour = Int32.Parse(Console.ReadLine());
                                fourthBus.AddPassenger(busFour);
                            }
                            else
                            {
                                fourthBus.AddPassenger(busFour);                            
                            }

                            Console.WriteLine("Enter the number of passengers in the fifth bus in the space below.");
                            int busFive = Int32.Parse(Console.ReadLine());
                            if (busFive > 30 || busFive <= 0)
                            {
                                Console.WriteLine("Only numbers between 1 and 30");
                                busFive = Int32.Parse(Console.ReadLine());
                                fifthBus.AddPassenger(busFive);
                            }
                            else
                            {
                                fifthBus.AddPassenger(busFive);                                                                                        

                            }
                            Console.WriteLine("");
                            break;
                        case 3:
                            //show taxis and bus
                            Console.Clear();
                            Console.WriteLine(                                         
                                              $"List of Taxis:\n" +
                                              $"Taxi patent {firstTaxi.Patent}: carrying {firstTaxi.Passengers} passengers.\n" +
                                              $"Taxi patent {secondTaxi.Patent}: carrying {secondTaxi.Passengers} passengers.\n" +
                                              $"Taxi patent {thirdTaxi.Patent}: carrying {thirdTaxi.Passengers} passengers.\n" +
                                              $"Taxi patent {fourthTaxi.Patent}: carrying {fourthTaxi.Passengers} passengers.\n" +
                                              $"Taxi patent {fifthTaxi.Patent}: carrying {fifthTaxi.Passengers} passengers.\n" +
                                        
                                              $"List of Buses:\n" +
                                              $"Taxi patent {firstBus.Line}: carrying {firstBus.Passengers} passengers.\n" +
                                              $"Taxi patent {secondBus.Line}: carrying {secondBus.Passengers} passengers.\n" +
                                              $"Taxi patent {thirdBus.Line}: carrying {thirdBus.Passengers} passengers.\n" +
                                              $"Taxi patent {fourthBus.Line}: carrying {fourthBus.Passengers} passengers.\n" +
                                              $"Taxi patent {fifthBus.Line}: carrying {fifthBus.Passengers} passengers.\n"
                                              );

                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Press enter to close...");
                            exit = true;
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

            Console.ReadLine();

        }
    }
}

