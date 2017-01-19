using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiePattern
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new Fly.FlyNormal();
            quackbehaviour = new Sounds.Quack();
        }

        public override void Display()
        {
            Console.WriteLine("Mallard");
        }

    }
}
