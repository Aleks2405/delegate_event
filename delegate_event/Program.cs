using System;

namespace delegate_event
{
    class Program
    {



        public delegate int Name(int a);
        static void Main(string[] args)
        {

            ICar[] a =
            {
                new Passenger_car(0),
                new Sports_car(0)
            };
           
            foreach (ICar asa in a)
            {
                
                Console.WriteLine(asa);
            }










        }

      
    }
}
   


