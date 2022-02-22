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
      
        public int temp,temp1;
        public Final()
        {
            var one = new Passenger_car(Const);
            var two = new Sports_car(Const);
            var thee = new Truck(Const);
            var four = new Bus(Const);

            ICar[] a = { one, two, thee,four };
            for (int i = 0; i < a.Length; i++)
            {
                //Array.Sort( (Array) a[i].casd());
                //if ( a[i].Count > temp)                                к сожалению сортировку не получилось организовать не какими методами 

                //{
                //    temp = a[i].Count;
                   
                //    temp1 = temp;
                //    Console.WriteLine($" {i+1} =  {a[i].Count} {a[i].ToString()}");
                //}
          

            }

            //foreach (ICar  aa in a)
            //{
            //    Console.WriteLine($"{aa.Count}");
            //}
            ////ICar[] a =
            ////  {
            ////    new Passenger_car(Const),
            ////    new Sports_car(Const),
            ////    new Truck(Const),
            ////    new Bus(Const)
            ////};



            foreach (ICar asa in a)
            {

                Console.WriteLine(asa);
            }
           

        }

    }
}
