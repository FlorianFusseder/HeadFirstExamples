using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiePattern
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehaviour = new Fly.FlyNot();
            quackbehaviour = new Sounds.Skweak();
        }
        public override void Display()
        {
            Console.WriteLine("Rubber");
        }
    }
}
