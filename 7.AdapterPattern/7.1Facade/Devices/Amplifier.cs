using _7._1Facade.Devices;
using System;

namespace _7._1Facade
{
    public class Amplifier : Device
    {

        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                Console.WriteLine($"{Name} changing Volume from {volume} to {value}");
                volume = value;
            }
        }

        public DvdPlayer Dvd { get; set; }

        public CdPlayer Cd { get; set; }

        public Amplifier(string name) : base(name)
        {
        }

        public void SetDvd(DvdPlayer dvd)
        {
            Dvd = dvd;
            Console.WriteLine($"Using {dvd?.Name} Player");
        }

        public void SetCd(CdPlayer cd)
        {
            Cd = cd;
            Console.WriteLine($" Using {cd.Name} Player");
        }

        public void SetSourroundSound()
        {
            Console.WriteLine($"Using Sourround Sound");
        }

        public void SetMonoSound()
        {
            Console.WriteLine($"Using Mono Sound");
        }


    }
}