using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_event
{
    class Final
    {
        public int Const { get; } = 0;  // точка старта
        public int Temp { get; } = 1;
        public int temp;
        public Final()
        {
            ICar[] a =
              {
                new Passenger_car(Const),
                new Sports_car(Const),
                new Truck(Const),
                new Bus(Const)
            };



            foreach (ICar asa in a)
            {

                Console.WriteLine(asa);
            }
            //for (int i = 0; i < a.Length; i++)
            // {
            //     if (a[i].casd() > temp)
            //     {

            //     }
            // }

            //foreach (ICar asa in saa)
            //{

            //    Console.WriteLine(asa);
            //}

        }

    }
}
