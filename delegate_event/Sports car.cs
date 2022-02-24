using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_event
{
    class Sports_car : Passenger_car
    {

        public new string Name { get; } = "Sport car";

        public Sports_car (int a) : base(a) {
           
        }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
