using _7._1Facade.Devices;
using System;

namespace _7._1Facade
{
    public class DvdPlayer: Device
    {
        public DvdPlayer(string name) : base(name)
        {
        }

        public void Play(string Movie)
        {
            Console.WriteLine($"Playing {Movie}...");
        }

        public void Stop()
        {
            Console.WriteLine($"Stoped Playing...");
        }

        public void Eject()
        {
            Console.WriteLine($"Eject DVD...");
        }
    }
}