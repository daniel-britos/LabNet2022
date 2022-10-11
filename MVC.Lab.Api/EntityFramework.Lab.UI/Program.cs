using EntityFramework.Lab.Entities;
using EntityFramework.Lab.Logic;
using EntityFramework.Lab.Logic.Methods;
using EntityFramework.Lab.UI.Menu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MENU            
            //bool exit = false;
            //do
            //{
            //    GeneralMenu.Menu();
            //    string option = Console.ReadLine();
            //    switch (option)
            //    {
            //        case "1":
            //            Console.Clear();
            //            EmployeesMenu.Menu();
            //            EmployeesMenu.ActionsMenu();
            //            break;
            //        case "2":
            //            Console.Clear();
            //            OrdersMenu.Menu();
            //            OrdersMenu.ActionsMenu();
            //            break;
            //        case "3":
            //            Console.Clear();
            //            CustomersMenu.Menu();
            //            CustomersMenu.ActionsMenu();
            //            break;
            //        case "4":
            //            Console.Clear();
            //            ShippersMenu.Menu();
            //            ShippersMenu.ActionsMenu();
            //            break;
            //        case "5":
            //            Console.Clear();
            //            Console.WriteLine("Press enter to close...");
            //            exit = true;
            //            break;
            //        default:
            //            break;
            //    }

            //} while (!exit);
            //Console.ReadKey();



            /*API CLIMA*/
            //http://api.weatherunlocked.com/api/current/40.71,-74.00?app_id=2a14523c&app_key=b5f0101353deff3514036987309331b3
            //string url = @"http://api.weatherunlocked.com/api/current/40.71,-74.00?app_id=2a14523c&app_key=b5f0101353deff3514036987309331b3";
            //WebRequest webRequest = WebRequest.Create(url);
            //HttpWebResponse httpWebResponse = null;
            //httpWebResponse = (HttpWebResponse)webRequest.GetResponse();

            //string result = string.Empty;
            //using (Stream stream = httpWebResponse.GetResponseStream())
            //{
            //    StreamReader streamReader = new StreamReader(stream);
            //    result = streamReader.ReadToEnd();
            //    streamReader.Close();
            //}

            //Console.ReadKey();
        }
    }
}
