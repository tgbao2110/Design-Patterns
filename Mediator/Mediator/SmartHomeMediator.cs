public class SmartHomeMediator : IMediator
{
    private Light _light;
    private Thermostat _thermostat;
    private Alarm _alarm;

    public void SetLight(Light light)
    {
        _light = light;
    }

    public void SetThermostat(Thermostat thermostat)
    {
        _thermostat = thermostat;
    }

    public void SetAlarm(Alarm alarm)
    {
        _alarm = alarm;
    }

    public void Notify(object sender, string ev)
    {
        if (ev == "alarm_triggered")
        {
            System.Console.WriteLine("Mediator reacts to alarm triggering and performs the following operations:");
            _light.TurnOn();
            _thermostat.SetTemperature(22);
        }
        else if (ev == "lights_off")
        {
            System.Console.WriteLine("Mediator reacts to lights being turned off and performs the following operations:");
            _alarm.Activate();
        }
    }
}
