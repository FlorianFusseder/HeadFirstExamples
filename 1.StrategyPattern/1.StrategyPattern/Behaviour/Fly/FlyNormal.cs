using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategiePattern.Fly
{
    class FlyNormal : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Normal");
        }
    }
}
