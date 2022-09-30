using LinQ.Lab.Entities;
using LinQ.Lab.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ.Lab.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductsLogic products = new ProductsLogic();
            CustomersLogic customers = new CustomersLogic();
            //foreach (Customers item in customers.GetAll())
            //{
            //Console.WriteLine($"{item.CustomerID} - {item.CompanyName} - {item.ContactName}");
            //QUICK - QUICK-Stop - Horst Kloss
            //}            

            //foreach (Products item in products.GetAll())
            //{
            //    Console.WriteLine($"{item.ProductID} - {item.ProductName} - {item.UnitPrice}");
            //    //49 - Maxilaku
            //}


            //1.OBTENER CUSTOMER
            //Console.WriteLine("BUSCAR CUSTOMER: ");
            //string id = Console.ReadLine();
            //var result = customers.GetCustomers(id).CompanyName;
            //Console.WriteLine(result);

            //2. PRODUCTOS SIN STOCK            
            //foreach (var item in products.GetProductsStock())
            //{
            //    Console.WriteLine($"{item.ProductID} - {item.ProductName} falta");
            //}

            //3 PRODUCTOS CON STOCK CON PRECIO MAYOR A 3
            //foreach (var item in products.GetProductsStockOverThree())
            //{
            //    Console.WriteLine($"{item.ProductID} - {item.ProductName} - {item.UnitPrice}");
            //}

            //4 CUSTOMERS DE LA REGION WA
            //foreach (var item in customers.GetCustomersRegionWa())
            //{
            //    Console.WriteLine($"{item.CustomerID} - {item.ContactName} - {item.Region}");
            //}

            //5 PRODUCTS ID 789            
            //var first = products.GetFirstElementOrNull();
            //if (first == null)
            //    Console.WriteLine("Es null");
            //else
            //    Console.WriteLine($"{first.ProductID} - {first.ProductName}");

            //6. NOMBRES CUSTOMER EN MAYUSCULA Y MINUSCULA
            //var names = customers.GetCustomersNameLowerUpper();
            //foreach (var item in names)
            //{
            //    Console.WriteLine($"UPPER CASE: {item.ContactName.ToUpper()} | lower case: {item.ContactName.ToLower()}");
            //}





            Console.ReadKey();

        }
    }
}
