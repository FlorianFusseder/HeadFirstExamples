using _7._1Facade.Devices;
using System;

namespace _7._1Facade
{
    public class PopcornPopper: Device
    {
        public PopcornPopper(string name) : base(name)
        {
        }

        internal void Pop()
        {
            Console.WriteLine("Popping the Corn");
        }
    }
}