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

        public string CustomMsg(Exception ex)
        {           
            string msg = "Location: " + ex.GetType() + "\nThrow: " + "\t" + ex.Message;
            return msg;
        }

    }
}
