using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaAdapter
{
    public class FahrenheitAdapter : ISensorTemperatura
    {
        public SensorFahrenheit adapter { get; set; }

        public FahrenheitAdapter(SensorFahrenheit sensorFahrenheit)
        {
            adapter = sensorFahrenheit;
        }
        
        public double obterCelsius()
        {
            double fahrenheit = adapter.obterFahrenheit();
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
