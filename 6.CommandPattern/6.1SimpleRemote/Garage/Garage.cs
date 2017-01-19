using System;

namespace SimpleRemote
{
    public class Garage
    {
        public bool Open { get; set; }

        public Garage()
        {
            Open = false;
        }

        public void SwitchOpen()
        {
            Console.WriteLine(this);
            Console.WriteLine("Garage -> Öffnen");
            Open = true;
            Console.WriteLine(this);
        }

        public void SwitchClose()
        {
            Console.WriteLine(this);
            Console.WriteLine("Garage -> Schließen");
            Open = false;
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return "Garage: " + Open;
        }
    }
}