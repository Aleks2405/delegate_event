using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_event
{
    class Bus : Passenger_car
    {
        public new string Name { get; } = "Bus";

        public Bus(int a) : base(a)
        {

        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
