using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ObserverPattern
{
    class ProgramInterface
    {
        static void Main(string[] args)
        {
            var wd = new Klasse.WeatherData();
            var dp = new Klasse.Display(wd);

            //var re = new Klasse.Rechner();
            //wd.registerObserver(re);

            wd.setValues(1, 2, 3);
            wd.setValues(2, 3, 4);
            wd.setValues(3, 4, 5);
            Console.ReadLine();
        }
    }
}
