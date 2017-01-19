using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1Facade
{
    class Program
    {
        static void Main(string[] args)
        {

            var homeTheater = new HomeTheaderFacade()
            {
                amp = new Amplifier("Amplifier"),
                dvd = new DvdPlayer("DVD Player"),
                lights = new TheaterLights("Lights"),
                pop = new PopcornPopper("Popcornmaschine"),
                pro = new Projector("Projector"),
                scr = new Screen("Screen"),
                tun = new Tuner("Tuner")
            };

            homeTheater.WatchMovie("12 Years a Slave");
            Console.WriteLine("\n\n");
            homeTheater.EndMovie();
            




        }
    }
}
