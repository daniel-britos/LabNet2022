using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.UI.Menu
{
    public class GeneralMenu
    {
        public static void Menu()
        {            
            Console.WriteLine(
                "||||||||||||||||||||| WELCOME TO THE EXERCISE WIZARD ||||||||||||||||||||||\n" +
                "||||||| The developer is not responsible if your terminal explodes ||||||||\n" +
                "Press 1 to manage employees.\n" +
                "Press 2 to manage orders..\n" +
                "Press 3 to manage customers.\n" +
                "Press 4 to manage shippers.\n" +                
                "Press 5 to EXIT."
            );
        }
        public static void MenuClose()
        {
            Console.WriteLine("Press another option...\n" +                               
                "Press 1 to manage employees.\n" +
                "Press 2 to manage orders..\n" +
                "Press 3 to manage customers.\n" +
                "Press 4 to manage shippers.\n" +
                "Press 5 to EXIT."
            );
        }
    }
}
