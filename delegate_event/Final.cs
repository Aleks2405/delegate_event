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
       
        private int temp = 4; /*Машин учавствующих в гонке*/

       

        public Final()
        {
            //this.temp = temp;

            var a = new List<ICar>()
            {
                new Passenger_car(Const),
                new Sports_car(Const),
                new Truck(Const),
                new Bus(Const)
            };
             for (int i = 0; i < a.Count; i++)
            {
                a = a.OrderBy(b => b.Countt).ToList(); // метод сортировки найден теперь красиво

            }
            
            foreach (ICar asa in a)
            {

                Console.WriteLine($"Finish = {asa} ");
            }
         
            
        }

        
    }
}
