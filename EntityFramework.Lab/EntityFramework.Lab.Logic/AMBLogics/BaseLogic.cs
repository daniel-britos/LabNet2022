using EntityFramework.Lab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab.Logic
{
    public class BaseLogic 
    {
        protected readonly NorthwindContext _context;
        public BaseLogic()
        {
            _context = new NorthwindContext();
        }
    }
}
