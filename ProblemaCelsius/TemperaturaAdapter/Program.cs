using TemperaturaAdapter;

public class Program
{
    static void Main()
    {
        // Sensores LEgado
        SensorFahrenheit sensorFahrenheit = new SensorFahrenheit(89.7);

        // Adaptadores
        FahrenheitAdapter fahrenheitAdapter = new FahrenheitAdapter(sensorFahrenheit);

        // Cliente final apenas usa a interface ISensorTemperatura
        ISensorTemperatura sensor1 = fahrenheitAdapter;
        Console.WriteLine($"Sensor 1: {sensor1.obterCelsius():F1}°C");
    }
}