using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ.Lab.Entities
{
    public class CustomOrder
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string Region { get; set; }    
        public DateTime? OrderDate { get; set; }
        public int? Amount { get; set; }
    }
}
