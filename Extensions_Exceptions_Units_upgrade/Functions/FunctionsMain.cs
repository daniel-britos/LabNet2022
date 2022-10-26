using Extensions_Exceptions_Units.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions_Exceptions_Units.Functions
{
    public static class FunctionsMain
    {
        public static void Menu()
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
        }

        public static void DivideSingle()
        {
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
                Console.WriteLine(ex.Message);
                Console.WriteLine(Environment.NewLine);
            }
        }

        public static void DivideTwo()
        {
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
        }

        public static void LogicMethod()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Press enter and you'll see...");
                Console.ReadLine();
                Logic oLogic = new Logic();
                oLogic.Throw();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Type name: " + ex.GetType().Name);
                Console.WriteLine(Environment.NewLine);
            }
        }

        public static void CustomMsgMenu()
        {
            try
            {
                Logic logic = new Logic();
                logic.CustomMsg();
            }
            catch (Logic ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
