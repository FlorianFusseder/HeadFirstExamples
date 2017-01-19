using _7._1Facade.Devices;
using System;

namespace _7._1Facade
{
    public class Projector: Device
    {

        public ScreenMode Mode { get; private set; }

        public enum ScreenMode
        {
            Normal,
            Widescreen
        }
        public Projector(string name) : base(name)
        {
            Mode = ScreenMode.Normal;
        }

        public void WideScreenMode()
        {
            Mode = ScreenMode.Widescreen;
            this.ToString();
        }

        public void NormalScreenMode()
        {
            Mode = ScreenMode.Normal;
            this.ToString();
        }

        public override string ToString()
        {
            return $"{Name} is in {Mode}";
        }
    }
}