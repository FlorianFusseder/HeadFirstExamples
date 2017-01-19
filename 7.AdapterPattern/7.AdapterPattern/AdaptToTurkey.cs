using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.AdapterPattern
{
    class AdaptToTurkey: Turkey
    {

        public Duck Duck { get; private set; }

        public AdaptToTurkey(Duck Duck)
        {
            this.Duck = Duck;
        }

        public void fly()
        {
            Duck.fly();
        }

        public void gobble()
        {
            Duck.quack();
        }
    }
}
