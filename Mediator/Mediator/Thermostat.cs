public class Thermostat : BaseDevice
{
    public void SetTemperature(int temperature)
    {
        System.Console.WriteLine($"Thermostat is set to {temperature}°C.");
    }
}
