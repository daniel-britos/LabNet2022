using LinQ.Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ.Lab.Logic
{
    public class OrdersLogic : BaseLogic
    {
        //7. Query para devolver Join entre Customers y Orders donde
        //los customers sean de la Región WA y la fecha de orden sea mayor a 1/1/1997.
        public List<string> CustomersAndOrders()
        {
            List<string> list = new List<string>(); 

            var query = from c in _context.Customers
                        join o in _context.Orders
                        on c.CustomerID equals o.CustomerID
                        where c.Region == "WA" && o.OrderDate > new DateTime(1997, 01, 01)
                        select new
                        {
                            c.Region,
                            c.ContactName,
                            o.OrderDate 
                        };

            foreach (var item in query)
            {
                list.Add("Region: " + item.Region);
                list.Add("Customer: " + item.ContactName);
                list.Add("Date: " + item.OrderDate.ToString());
            }
            return list;
        }        
    }
}
