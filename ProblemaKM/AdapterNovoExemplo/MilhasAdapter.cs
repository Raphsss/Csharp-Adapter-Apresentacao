using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterNovoExemplo
{
    public class MilhasAdapter : ISensorDistancia
    {
        private SensorMilhas adapter { get; set; }

        public MilhasAdapter(SensorMilhas sensor)
        {
            adapter = sensor;
        }

        public double obterKM()
        {
            double km = adapter.obterMilhas() * 1.60934;
            return km;
        }
    }
}
