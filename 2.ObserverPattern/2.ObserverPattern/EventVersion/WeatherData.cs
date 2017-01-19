using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ObserverPattern.EventVersion
{
    class WeatherData
    {
        private float temp;
        private float humidity;
        private float pressure;
        public Action<float, float, float> notifyObserver;

        public WeatherData()
        {

        }

        public void setValues(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            notifyObserver(temp, humidity, pressure);
        }
    }
}
