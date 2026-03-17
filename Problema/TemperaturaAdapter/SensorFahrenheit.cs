namespace TemperaturaAdapter
{
    public class SensorFahrenheit
    {
        public double temperaturaFahrenheit { get; set; }

        public SensorFahrenheit(double temp)
        {
            temperaturaFahrenheit = temp;
        }
        public double obterFahrenheit()
        {
            return temperaturaFahrenheit;
        }
    }
}
