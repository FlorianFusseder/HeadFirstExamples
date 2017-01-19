using _7._1Facade.Devices;
using System;

namespace _7._1Facade
{
    public class Screen: Device
    {
        public Position ScreenPosition { get; private set; }
        public enum Position
        {
            Up,
            Down
        }

        public Screen(string name) : base(name)
        {
            ScreenPosition = Position.Up;
        }

        public override void Off()
        {
            Console.WriteLine($"Going into {Position.Up} Mode");
            base.Off();
        }

        public void Down()
        {
            Console.WriteLine($"Going into {Position.Down} Mode");
        }

        internal void Up()
        {
            Console.WriteLine($"Going into {Position.Up} Mode");
        }
    }
}