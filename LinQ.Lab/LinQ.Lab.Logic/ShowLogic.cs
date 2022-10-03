using LinQ.Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ.Lab.Logic.ShowLogic
{
    //ProductsLogic products = new ProductsLogic();
    //CustomersLogic customers = new CustomersLogic();
    public class ShowLogic
    {
        public static void Exercise1()
        {
            CustomersLogic customers = new CustomersLogic();
            string id = Console.ReadLine();
            var results = customers.GetCustomers(id);
            Console.WriteLine("Nombre de la compania: " + results.CompanyName);
        }
        public static void Exercise2()
        {
            ProductsLogic products = new ProductsLogic();
            List<Products> product = products.GetProductsStock();
            foreach (var item in product)
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName} falta");
            }
        }
        public static void Exercise3()
        {
            ProductsLogic products = new ProductsLogic();
            foreach (var item in products.GetProductsStockOverThree())
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName} - ${item.UnitPrice}");
            }
        }
        public static void Exercise4()
        {
            CustomersLogic customers = new CustomersLogic();
            foreach (var item in customers.GetCustomersRegionWa())
            {
                Console.WriteLine($"{item.CustomerID} - {item.ContactName} - {item.Region}");
            }
        }
        public static void Exercise5()
        {
            ProductsLogic products = new ProductsLogic();
            var first = products.GetFirstElementOrNull();
            if (first == null)
                Console.WriteLine("Es null");
            else
                Console.WriteLine($"{first.ProductID} - {first.ProductName}");
        }
        public static void Exercise6()
        {
            CustomersLogic customers = new CustomersLogic();
            var names = customers.GetCustomersNameLowerUpper();
            foreach (var item in names)
            {
                Console.WriteLine($"Mayuscula: {item.ContactName.ToUpper()} | Minuscula: {item.ContactName.ToLower()}");
            }
        }
        public static void Exercise7()
        {
            CustomersLogic customers = new CustomersLogic();
            //CustomOrder customOrder = new CustomOrder();
            foreach (var item in customers.GetCustomersOrders())
            {
                Console.WriteLine($"Nombre contacto: {item.ContactName} | Region: {item.Region} | Fecha: {item.OrderDate} | ID: {item.CustomerID}");
            }
        }
        public static void Exercise8()
        {
            CustomersLogic customers = new CustomersLogic();
            var result = customers.GetThreeFirstCustomersRegionWa();
            foreach (var item in result)
            {
                Console.WriteLine($"Nombre de contacto: {item.ContactName} - Region: {item.Region}");
            }
        }
        public static void Exercise9()
        {
            ProductsLogic products = new ProductsLogic();
            var listName = products.GetListProductByName();
            foreach (var item in listName)
            {
                Console.WriteLine(item.ProductName);
            }
        }
        public static void Exercise10()
        {
            ProductsLogic products = new ProductsLogic();
            var inStock = products.GetSortByUnitInStock();
            foreach (var item in inStock)
            {
                Console.WriteLine($" Stock: {item.UnitsInStock} | {item.ProductName} - {item.UnitPrice}");
            }
        }
        public static void Exercise11()
        {
            ProductsLogic products = new ProductsLogic();
            var category = products.GetCategoriesProducts();
            foreach (var item in category)
            {
                Console.WriteLine(item);
            }
        }
        public static void Exercise12()
        {
            ProductsLogic products = new ProductsLogic();
            var element = products.GetFirstElementProduct();
            Console.Write("Nombre: " + element.ProductName);
        }
        public static void Exercise13()
        {            
            CustomersLogic customers = new CustomersLogic();
            var query = customers.GetCustomerAmountOrders();
            foreach (var c in query)
            {
                Console.WriteLine($"Customer: {c.ContactName}, Ordenes asociadas: {c.Amount}");
            }
        }
        public static void List() 
        {
            ProductsLogic products = new ProductsLogic();
            foreach (Products item in products.GetAll())
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName} - {item.UnitPrice}");
            }
        }        
    }
}
