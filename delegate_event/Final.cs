using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_event
{
    class Final
    {
        public delegate void Number();
        public event Number Shethic; 
        public int Const { get; } = 0;  // точка старта
       
        private int temp = 4; /*Машин учавствующих в гонке*/

        public void IIII()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
                Shethic?.Invoke();
            }
        }

        public Final()
        {
            this.temp = temp;

            var a = new List<ICar>()
            {
                new Passenger_car(Const),
                new Sports_car(Const),
                new Truck(Const),
                new Bus(Const)
            };
             for (int i = 0; i < 4; i++)
            {
                a = a.OrderBy(b => b.Count).ToList(); // метод сортировки найден теперь красиво

            }
            Shethic += Final_Shethic;       // нужно обьяснения( желательно показать на примере кода биться саму уже не хватает нервов )
                                            // я понял зачем нужны делегаты но не понимаю зачем нужны события они все только усложняют      

            foreach (ICar asa in a)
            {

                Console.WriteLine($"Finish = {asa} ");
            }
         
            
        }

        private void Final_Shethic()
        {
            throw new NotImplementedException();
        }
    }
}
