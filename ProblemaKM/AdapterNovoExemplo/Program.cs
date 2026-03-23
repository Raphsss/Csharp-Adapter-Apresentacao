using AdapterNovoExemplo;

public class Program
{
    static void Main()
    {
        SensorMilhas sendorMilhas = new SensorMilhas(100);

        // adapter
        ISensorDistancia milhasAdapter = new MilhasAdapter(sendorMilhas);

        Console.WriteLine(milhasAdapter.obterKM()) ;
    }
}