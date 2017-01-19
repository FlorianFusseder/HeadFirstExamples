using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ObserverPattern.Klasse
{
    class Display : Interface.Observer, Interface.DisplayElement
    {
        private float temp;
        private float humidity;
        private float pressure;
        Interface.Subject s;

        private String text;

        public String Text
        {
            get { return text; }
            set { text = value; }
        }

        public Display(Interface.Subject s)
        {
            this.s = s;
            this.s.registerObserver(this);
        }

        public void display()
        {
            text = String.Format("Temperatur: {0}\nLuftfeuchtigkeit: {1}\nLuftdruck: {2}", temp, humidity, pressure);
            Console.WriteLine(text);
            Console.WriteLine();
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
        }
    }
}
