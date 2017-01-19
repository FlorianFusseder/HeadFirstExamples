using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ObserverPattern.Klasse
{
    class Rechner : Interface.Observer
    {
        public Rechner()
        {
        }

        public void update(float temp, float humidity, float pressure)
        {
            Console.WriteLine(temp + humidity + pressure);
        }
    }
}
