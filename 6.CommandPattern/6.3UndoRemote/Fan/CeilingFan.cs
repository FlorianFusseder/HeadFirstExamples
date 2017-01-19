using System;

namespace ComplexRemote
{
    public enum FanSpeed
    {
        low,
        medium,
        high,
        extrem,
    }

    public class CeilingFan
    {
        private string v;

        public bool On { get; set; }

        private FanSpeed s;

        public FanSpeed Stufe
        {
            get { return s; }
            set
            {
                Console.WriteLine($"Set To {value} from {s}");
                s = value;
            }
        }



        public CeilingFan()
        {
            On = false;
            s = FanSpeed.medium;
        }

        public CeilingFan(string v) : this()
        {
            this.v = v;
        }

        public void StartFan()
        {
            Console.WriteLine(this);
            Console.WriteLine("Fan -> Starten");
            On = true;
            Console.WriteLine(this);
            Console.WriteLine();
        }

        public void StopFan()
        {
            Console.WriteLine(this);
            Console.WriteLine("Fan -> Stopen");
            On = false;
            Console.WriteLine(this);
            Console.WriteLine();
        }

        public override string ToString()
        {
            return (v == string.Empty) ? "CeilingFan: " + On : v + ": " + On;
        }
    }
}