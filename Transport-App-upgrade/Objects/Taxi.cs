using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Transport_App
{
    public class Taxi : PublicTransport
    {
        public Taxi(int passengers, string type) : base(passengers, type)
        { 
            this.Passengers = passengers; 
            this.Type = type;   
        }

        public override string Move()
        {
            return "Taxi in moving";
        }
        public override string Stop()
        {
            return "Taxi stop";
        }
    }
}   
