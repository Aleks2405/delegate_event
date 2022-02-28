using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_event
{
    class Passenger_car :ICar
    {
        public int Countt { get; set; } = 0;
        public int a;
        public delegate void POexali(int a);
        public event POexali op;
        public int skorost { get; } = 100;

        public string Name { get;  } = "Passenger car"; 
        
        public Passenger_car(int a)  // начало пути 
        { 
            this.a = a;
            if (a == 0)
            {
                /*POexali op = new(poexali)  убрал делегат использую сабытие*/
                poexali(); 
                op?.Invoke(Countt);  //наверное разобрался если так то я понял, ну с учетом что мы вызываем функцию и нечего в нее не передаем
            }
            else
            {
                throw new Exception("кинули исключение");
            }
                              
        }
        public int poexali ()   //расчет скарости автомобиля
        {            
                while (a <= skorost)          
                {
                    a += speed();                    
                    Countt++;
                }
            return Countt++;
        }
       
     public int speed ()             // задаем скорость автомобиля
        {
           int a = new Random().Next(15);
            return a;
        }
        public int casd()    // возвращаем значения нашего счетика у кого меньше тот и выиграл
        {
            return Countt;
        }
        public override string ToString()
        {
            return $"{Name}";
        }

        //public int CompareTo(object o)
        //{                                                                          /*пока убрали так как не работает*/ 
        //    if (o is ICar a) return Count.CompareTo(a.Count);
        //    else throw new ArgumentException("Некорректное значение параметра");
        //}
    }
}
