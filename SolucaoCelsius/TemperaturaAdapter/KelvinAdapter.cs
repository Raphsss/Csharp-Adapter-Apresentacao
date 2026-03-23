using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaAdapter
{
    public class KelvinAdapter : ISensorTemperatura
    {
        public SensorKelvin adapter { get; set; }

        public KelvinAdapter(SensorKelvin sensorKelvin)
        {
            adapter = sensorKelvin;
        }

        public double obterCelsius()
        {
            double kelvin = adapter.obterKelvin();
            return kelvin - 273.15;
        }
    }
}
