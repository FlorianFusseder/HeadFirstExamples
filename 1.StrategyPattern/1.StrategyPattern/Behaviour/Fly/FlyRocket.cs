using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiePattern.Fly
{
    class FlyRocket : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Rocket");
        }
    }
}
