using LinQ.Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LinQ.Lab.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public List<Customers> GetAll()
        {
            return _context.Customers.ToList();
        }
        //1. Query para devolver objeto customer
        public Customers GetCustomers(string id)
        {
           
            var customer = _context.Customers.Where(c => c.CustomerID == id).Single();                
            return customer;
        }
        //4. Query para devolver todos los customers de la Región WA
        public List<Customers> GetCustomersRegionWa()
        {
             return _context.Customers.Where(p => p.Region == "WA").ToList();
        }
        
        //6. Query para devolver los nombre de los Customers.Mostrarlos en Mayuscula y en Minuscula.
        public List<Customers> GetCustomersNameLowerUpper()
        {
            var query = from c in _context.Customers select c;
            return query.ToList();
        }
        //7. Query para devolver Join entre Customers y Orders donde los customers
        //sean de la Región WA y la fecha de orden sea mayor a 1/1/1997.
        public List<CustomOrder> GetCustomersOrders()
        {
            var query = from c in _context.Customers
                        join o in _context.Orders
                        on c.CustomerID equals o.CustomerID
                        where c.Region == "WA" && o.OrderDate > new DateTime(1997, 1, 1)
                        select new CustomOrder
                        {
                            CustomerID = c.CustomerID,
                            ContactName = c.ContactName,
                            Region = c.Region,
                            OrderDate = o.OrderDate
                        };

            return query.ToList();
        }
        //8. Query para devolver los primeros 3 Customers de la Región WA
        public List<Customers> GetThreeFirstCustomersRegionWa()
        {
            var query = _context.Customers.Where(c => c.Region == "WA")
                                          .Take(3)
                                          .ToList();            
            return query;
        }
        //13. Query para devolver los customer con
        //la cantidad de ordenes asociadas
       public List<CustomOrder> GetCustomerAmountOrders() 
        {
            var query = from c in _context.Customers
                        join o in _context.Orders
                        on c.CustomerID equals o.CustomerID
                        group c by c.ContactName into cusOrder
                        select new CustomOrder
                        {
                            ContactName = cusOrder.Key,
                            Amount = cusOrder.Count()
                        };
            return query.ToList();
        }        
    }
}
