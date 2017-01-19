using System;

namespace ComplexRemote
{
    public class Light
    {
        private bool on;
        private string v;

        public bool On
        {
            get { return on; }
            set { on = value; }
        }

        public Light()
        {
            on = false;
        }

        public Light(string v): base()
        {
            this.v = v;
        }

        internal void SwitchOn()
        {
            Console.WriteLine(this);
            on = true;
            Console.WriteLine("Licht -> Anschalten");
            Console.WriteLine(this);
            Console.WriteLine();
        }

        internal void SwitchOff()
        {
            Console.WriteLine(this);
            on = false;
            Console.WriteLine("Licht -> Ausschalten");
            Console.WriteLine(this);
            Console.WriteLine();
        }

        public override string ToString()
        {
            return (v == string.Empty) ? "Light: " + On : v + ": " + On;
        }
    }
}