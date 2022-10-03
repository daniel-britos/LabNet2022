using LinQ.Lab.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
            if (customer == null) throw new Exception();
            else return customer;
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
        //8. Query para devolver los primeros 3 Customers de la  Región WA

        public List<Customers> GetFirstThreeCustomers()
        {
            var query = from c in _context.Customers
                        where c.Region == "WA"
                        select c;
            query.Take(3);
            return query.ToList();
        }

    }
}
