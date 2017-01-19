using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.AdapterPattern
{
    class AdaptToDuck : Duck
    {

        public Turkey Turk { get; private set; }

        public AdaptToDuck(Turkey t)
        {
            Turk = t;
        }

        public void fly()
        {
            Turk?.fly();
        }

        public void quack()
        {
            Turk.gobble();
        }
    }
}
