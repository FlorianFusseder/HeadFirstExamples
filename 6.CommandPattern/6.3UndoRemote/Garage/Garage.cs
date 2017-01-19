using System;

namespace ComplexRemote
{
    public class Garage
    {
        private string v;

        public bool Open { get; set; }

        public Garage()
        {
            Open = false;
        }

        public Garage(string v): this()
        {
            this.v = v;
        }

        public void SwitchOpen()
        {
            Console.WriteLine(this);
            Console.WriteLine("Garage -> Öffnen");
            Open = true;
            Console.WriteLine(this);
            Console.WriteLine();
        }

        public void SwitchClose()
        {
            Console.WriteLine(this);
            Console.WriteLine("Garage -> Schließen");
            Open = false;
            Console.WriteLine(this);
            Console.WriteLine();
        }

        public override string ToString()
        {
            return (v == string.Empty) ? "Garage: " + Open : v + ": " + Open;
        }
    }
}