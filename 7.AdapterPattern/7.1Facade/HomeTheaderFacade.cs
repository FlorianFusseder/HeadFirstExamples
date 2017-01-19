using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1Facade
{
    class HomeTheaderFacade
    {

        public Amplifier amp { get; set; }
        public Tuner tun { get; set; }
        public DvdPlayer dvd { get; set; }
        public Projector pro { get; set; }
        public TheaterLights lights { get; set; }
        public Screen scr { get; set; }
        public PopcornPopper pop { get; set; }

        public HomeTheaderFacade()
        {

        }

        public HomeTheaderFacade(Amplifier amp, Tuner tun, DvdPlayer dvd, Projector pro, TheaterLights lights, Screen scr, PopcornPopper pop)
        {
            this.amp = amp;
            this.tun = tun;
            this.dvd = dvd;
            this.pro = pro;
            this.lights = lights;
            this.scr = scr;
            this.pop = pop;
        }

        internal void WatchMovie(string movie)
        {
            Console.WriteLine($"Get ready to watch a movie...");
            pop.On();
            pop.Pop();
            lights.On();
            lights.Dim(10);
            scr.Down();
            pro.On();
            pro.WideScreenMode();
            amp.On();
            amp.Dvd = dvd;
            amp.SetSourroundSound();
            amp.Volume = 5;
            dvd.On();
            dvd.Play(movie);
        }

        internal void EndMovie()
        {
            Console.WriteLine($"Shutting down movie theater...");
            pop.Off();
            lights.On();
            scr.Up();
            pro.Off();
            amp.Off();
            dvd.Stop();
            dvd.Eject();
            dvd.Off();
        }
    }
}
