using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Transport_App
{
    public abstract class PublicTransport
    {
        private int _passengers;
        private string _type;

        public PublicTransport(int passengers, string type) 
        {
            this.Passengers = passengers;
            _type = type;
        }

        public int Passengers
        {
            get { return _passengers; } 
            set { _passengers = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public abstract string Move();
        public abstract string Stop();
       
    }

}
