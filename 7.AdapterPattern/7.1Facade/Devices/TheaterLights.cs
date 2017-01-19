using _7._1Facade.Devices;
using System;

namespace _7._1Facade
{
    public class TheaterLights : Device
    {
        public int DimLevel { get; private set; }

        public TheaterLights(string name) : base(name)
        {

        }

        public void Dim(int newDimLevel)
        {
            if (PowerState == Power.On)
            {
                Console.WriteLine($"Brightnes from {DimLevel} to {newDimLevel}");
                DimLevel = newDimLevel;
            }
        }
    }
}