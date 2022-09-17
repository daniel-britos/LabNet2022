using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_App
{
    public class Taxi : PublicTransport
    {
        public string Patent { get; set; }
        public Taxi(int Passengers, string patent) : base(Passengers)
        {     
            this.Patent = patent;
        }

        public override int AddPassenger(int passenger)
        {
            return Passengers += passenger;
        }
        
        public override string MoveForeward()
        {
            return "Method MoveForeward turned off in Taxi class.";
        }
        
        public override string Stop()
        {
            return "Method Stop turned off in Taxi class.";
        }
    }
}
