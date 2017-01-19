using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiePattern.Sounds
{
    class Quack : QuackBehaviour
    {
        public void MakeSound()
        {
            Console.WriteLine("Quack");
        }
    }
}
