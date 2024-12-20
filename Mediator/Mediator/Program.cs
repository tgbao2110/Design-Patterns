class Program
{
    static void Main(string[] args)
    {
        SmartHomeMediator mediator = new SmartHomeMediator();

        Light light = new Light();
        Thermostat thermostat = new Thermostat();
        Alarm alarm = new Alarm();

        light.Mediator = mediator;
        thermostat.Mediator = mediator;
        alarm.Mediator = mediator;

        mediator.SetLight(light);
        mediator.SetThermostat(thermostat);
        mediator.SetAlarm(alarm);

        System.Console.WriteLine("Alarm is triggered:");
        alarm.Activate();

        System.Console.WriteLine("\nTurning off the light:");
        light.TurnOff();
    }
}
