using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_App
{
    public class Bus : PublicTransport
    {
        public int Line { get; set; }
        public Bus(int Passengers, int line) : base(Passengers)
        {
            this.Line = line;
        }

        public override int AddPassenger(int passenger)
        {
            return Passengers += passenger;
        }
        public override void DeletePassenger()
        {
            Passengers = 0;
        }

        public override string MoveForeward()
        {
            return "Method MoveForeward turned off in Bus class.";
        }
        
        public override string Stop()
        {
            return "Method Stop turned off in bus class.";
        }
    }
}
