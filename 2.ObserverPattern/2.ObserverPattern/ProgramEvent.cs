using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ObserverPattern
{
    class ProgramEvent
    {
        static void Main(string[] args)
        {

            var wd = new EventVersion.WeatherData();
            var ob = new EventVersion.Display();

            wd.notifyObserver += ob.update;

            wd.setValues(1, 2, 3);
            wd.setValues(3, 4, 5);
            Console.ReadLine();


        }
    }
}
