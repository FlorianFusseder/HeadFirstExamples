using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.ObserverPattern.Interface;

namespace _2.ObserverPattern.Klasse
{
    class WeatherData : Interface.Subject
    {
        private float temp;
        private float humidity;
        private float pressure;
        private List<Observer> observer;

        public WeatherData()
        {
            observer = new List<Observer>();
        }

        public void notifyObserver()
        {
            foreach (var item in observer)
            {
                item.update(temp, humidity, pressure);
            }
        }

        public void registerObserver(Observer o)
        {
            observer.Add(o);
        }

        public void removeObserver(Observer o)
        {
            int i = observer.IndexOf(o);
            if (i > 0)
                observer.RemoveAt(i);
        }

        public void valuesUpdated()
        {
            notifyObserver();
        }

        public void setValues(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            valuesUpdated();
        }
    }
}
