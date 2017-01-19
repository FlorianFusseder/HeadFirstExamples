using System;

namespace SimpleRemote
{
    public class Light
    {
        private bool on;

        public bool On
        {
            get { return on; }
            set { on = value; }
        }

        public Light()
        {
            on = false;
        }

        internal void SwitchOn()
        {
            Console.WriteLine(this);
            on = true;
            Console.WriteLine("Licht -> Anschalten");
            Console.WriteLine(this);
        }

        internal void SwitchOff()
        {
            Console.WriteLine(this);
            on = false;
            Console.WriteLine("Licht -> Ausschalten");
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return "Light: " + on;
        }
    }
}