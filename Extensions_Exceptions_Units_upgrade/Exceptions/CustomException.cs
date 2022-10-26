using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions_Exceptions_Units.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException() : base("Error system!!!!!!")
        {

        }
    }
}
