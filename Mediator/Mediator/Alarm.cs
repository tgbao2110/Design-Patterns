public class Alarm : BaseDevice
{
    public void Activate()
    {
        System.Console.WriteLine("Alarm is activated.");
        _mediator.Notify(this, "alarm_triggered");
    }

    public void Deactivate()
    {
        System.Console.WriteLine("Alarm is deactivated.");
    }
}
