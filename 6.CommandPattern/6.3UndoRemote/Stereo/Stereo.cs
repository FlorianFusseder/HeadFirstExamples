using System;

namespace ComplexRemote
{
    public class Stereo
    {
        private string v;
        public bool On { get; set; }
        public bool IsDVD { get; set; }
        public bool IsCD { get; set; }
        public bool IsRadio { get; set; }
        private double Volume { get; set; }

        public Stereo()
        {
            On = false;
            IsDVD = false;
            IsCD = false;
            IsRadio = false;
            Volume = .5;
        }

        public Stereo(string v) : this()
        {
            this.v = v;
        }

        public void ChooseCD()
        {
            Console.WriteLine("CD Einlegen");
            IsCD = true;
            IsDVD = false;
        }

        public void ChooseDVD()
        {
            Console.WriteLine("DVD Einlegen");
            IsCD = false;
            IsDVD = true;
        }

        public void SetVolume(double val)
        {
            Volume = val;
        }

        public void StereoStart()
        {
            Console.WriteLine(this);
            Console.WriteLine("Stereo -> Starten");
            On = true;
            Console.WriteLine(this);
            Console.WriteLine();
        }

        public void StereoStop()
        {
            Console.WriteLine(this);
            Console.WriteLine("Stereo -> Stopen");
            On = false;
            Console.WriteLine(this);
            Console.WriteLine();
        }

        public override string ToString()
        {
            return (v == string.Empty)? "Stereo: " + On: v + ": " + On;
        }
    }
}