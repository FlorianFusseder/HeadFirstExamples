using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _7._1Facade.Devices
{
    public abstract class Device
    {
        public string Name { get; set; }
        public Power PowerState { get; private set; } = Power.Off;

        public enum Power
        {
            On,
            Off,
        }

        public Device(string name)
        {
            Name = name;
        }

        public virtual void On()
        {
            switch (PowerState)
            {
                case Power.On:
                    Console.WriteLine($"{Name} already Running");
                    break;
                case Power.Off:
                    Console.WriteLine($"Starting {Name}...");
                    PowerState = Power.On;
                    break;
                default:
                    throw new NotSupportedException($"Device Enum not Supported");
            }
        }

        public virtual void Off()
        {
            switch (PowerState)
            {
                case Power.On:
                    Console.WriteLine($"Stopping {Name}...");
                    PowerState = Power.Off;
                    break;
                case Power.Off:
                    Console.WriteLine($"{Name} already Off");
                    break;
                default:
                    break;
            }
        }
    }
}
