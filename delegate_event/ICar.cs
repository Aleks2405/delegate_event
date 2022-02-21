using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_event
{
     interface ICar
    {
        int Count { get; set; }
        string Name { get; }
        int speed();
        int casd();
        public virtual string ToString()
        {
            return $"{Name} = {Count}";
        }

    }
}
