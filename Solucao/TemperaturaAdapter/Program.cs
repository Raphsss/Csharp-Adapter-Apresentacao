using TemperaturaAdapter;

public class Program
{
    static void Main()
    {
        // Sensores LEgado
        SensorFahrenheit sensorFahrenheit = new SensorFahrenheit(89.7);
        SensorKelvin sensorKelvin = new SensorKelvin(300);

        // Adaptadores
        FahrenheitAdapter fahrenheitAdapter = new FahrenheitAdapter(sensorFahrenheit);
        KelvinAdapter kelvinAdapter = new KelvinAdapter(sensorKelvin);

        // Cliente final apenas usa a interface ISensorTemperatura
        ISensorTemperatura sensor1 = fahrenheitAdapter;
        Console.WriteLine($"Sensor 1: {sensor1.obterCelsius():F1}°C");

        ISensorTemperatura sensor2 = kelvinAdapter;
        Console.WriteLine($"Sensor 2: {sensor2.obterCelsius():F1}°C");
    }
}