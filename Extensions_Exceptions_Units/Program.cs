using Extensions_Exceptions_Units.Extensions;
using Extensions_Exceptions_Units.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
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
                FunctionsMain.Menu();
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        FunctionsMain.DivideSingle();
                        break;
                    case "2":
                        FunctionsMain.DivideTwo();
                        break;
                    case "3":
                        FunctionsMain.LogicMethod();
                        break;
                    case "4":
                        FunctionsMain.CustomMsg();
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

            Console.ReadLine();

        }
    }
}
