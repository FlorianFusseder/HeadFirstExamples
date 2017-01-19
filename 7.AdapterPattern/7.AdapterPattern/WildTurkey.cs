using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.AdapterPattern
{
    class WildTurkey : Turkey
    {
        public void fly()
        {
            Console.WriteLine($"Fly like a Turkey");
        }

        public void gobble()
        {
            Console.WriteLine($"Gobble like a Turkey");
        }
    }
}
