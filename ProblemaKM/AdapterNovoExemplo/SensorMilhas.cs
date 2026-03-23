using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterNovoExemplo
{
    public class SensorMilhas
    {
        private double _distancia { get; set; }

        public SensorMilhas(double distancia)
        {
            _distancia = distancia;
        }

        public double obterMilhas() 
        { 
            return _distancia;
        }
    }
}
