using Extensions_Exceptions_Units.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Extensions_Exceptions_Units
{
    public class Logic : Exception
    {

        public Logic() : base("Personalized message")
        {
        }
        public void Throw()
        {
            throw new NotImplementedException();
        }

        public string CustomMsg()
        {
            throw new CustomException();
        }

    }
}
