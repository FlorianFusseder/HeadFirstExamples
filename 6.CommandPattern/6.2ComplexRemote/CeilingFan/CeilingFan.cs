using System;

namespace ComplexRemote
{
    public class CeilingFan
    {
        private string v;

        public bool On { get; set; }

        public CeilingFan()
        {
            On = false;
        }

        public CeilingFan(string v) : base()
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