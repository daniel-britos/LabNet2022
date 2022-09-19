using Extensions_Exceptions_Units.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Extensions_Exceptions_Units
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MENU
            
            bool exit = false;
            do
            {
                Console.WriteLine(
                    "||||||||||||||||||||| WELCOME TO THE EXERCISE WIZARD ||||||||||||||||||||||\n" +
                    "||||||| The developer is not responsible if your terminal explodes. |||||||\n" +
                    "Press 1 to see Exercise number (1).\n" +
                    "Press 2 to see Exercise number (2).\n" +
                    "Press 3 to see Exercise number (3).\n" +
                    "Press 4 to see Exercise number (4).\n" +
                    "Press 5 to EXIT."
                );
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter number..");
                            int number = Convert.ToInt32(Console.ReadLine());
                            number.DivideSingleNumber();
                            Console.WriteLine(Environment.NewLine);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Sure you entered a letter or you entered nothing!");
                            Console.WriteLine(Environment.NewLine);
                        }
                        break;
                    case "2":
                        try
                        {
                            Console.Clear();

                            Console.WriteLine("Enter the dividend");
                            int dividend = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the divider: ");
                            int divider = Convert.ToInt32(Console.ReadLine());
                            MyExtension.DivideTwoNumbers(dividend, divider);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Sure you entered a letter or you entered nothing!");
                            Console.WriteLine(Environment.NewLine);                            
                        }
                        break;
                    case "3":
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Press enter and you'll see...");
                            Console.ReadLine();
                            Logic oLogic = new Logic();
                            oLogic.Throw();
                        }
                        catch(Exception ex) 
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Type name: " + ex.GetType().Name);
                            Console.WriteLine(Environment.NewLine);
                        }
                        break;
                    case "4":
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Press enter my friend...");
                            Console.ReadLine();
                            throw new Logic();
                        }
                        catch (Logic ex)
                        {
                            Console.WriteLine(ex.CustomMsg(ex));
                            Console.WriteLine(Environment.NewLine);
                        }
                        break;
                    case "5":
                        Console.Clear();                        
                        Console.WriteLine("Press enter to close...");
                        exit = true;
                        break;                        
                    default:
                        break;
                }

            } while (!exit);




















            //int number = 11;
            //number.DivideSingleNumber();
            /*
            try
            {

                Console.WriteLine("Ingrese el dividendo: ");
                int? dividend = Convert.ToInt32(Console.ReadLine());
            
                Console.WriteLine("Ingrese el dividendo: ");
                int? divider = Convert.ToInt32(Console.ReadLine());
                MyExtension.DivideTwoNumbers(dividend, divider);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Sure you entered a letter or you entered nothing!");
            }


            
            */




            Console.ReadLine();
        }
    }
}
