using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_App
{
    public class Bus : PublicTransport
    {
        public Bus(int passengers, string type) : base(passengers, type)
        {
            this.Passengers = passengers;
            this.Type = type;
        }
        public override string Move()
        {
            return "Bus moving";
        }
        public override string Stop()
        {
            return "Bus stop";
        }
    }

    
}
