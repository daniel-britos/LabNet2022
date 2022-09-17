using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_App
{
    public abstract class PublicTransport
    {
        private int _passengers;
        //private string _typeOfTransport = "Public transport";

        public PublicTransport(int passengers)
        {
            this.Passengers = passengers;
        }

        public int Passengers { get => _passengers; set => _passengers = value; }

        public abstract int AddPassenger(int passenger);
        public abstract void DeletePassenger();
        public abstract string MoveForeward();
        public abstract string Stop();



    }
}
