using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.AdapterPattern
{
    class MallardDuck : Duck
    {
        public void fly()
        {
            Console.WriteLine($"Fly like a duck");
        }

        public void quack()
        {
            Console.WriteLine($"Quack like a duck");
        }
    }
}
