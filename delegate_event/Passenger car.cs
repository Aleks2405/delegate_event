using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_event
{
    class Passenger_car :ICar
    {
        public int Count { get; set; } = 0;
        public int a;
        public delegate void POexali(); 

        public string Name { get;  } = "Passenger car"; 
        
        public Passenger_car(int a)  // начало пути 
        { 
            this.a = a;
            if (a == 0)
            {
                POexali op = new(poexali);
                op.Invoke();
            }
            else
            {
                Console.WriteLine(  "кидаем исключение");
            }
                              
        }
        public void poexali ()
        {            
                while (a <= 100)
                {
                    a += speed();                    
                    Count++;
                }           
        }
       
     public int speed ()
        {
           int a = new Random().Next(15);
            return a;
        }
        public int casd()
        {
            return Count;
        }
        public override string ToString()
        {
            return $"{Name} = {Count}";
        }
    }
}
