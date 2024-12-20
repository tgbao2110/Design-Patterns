public class Light : BaseDevice
{
    public void TurnOn()
    {
        System.Console.WriteLine("Light is turned on.");
        _mediator.Notify(this, "lights_on");
    }

    public void TurnOff()
    {
        System.Console.WriteLine("Light is turned off.");
        _mediator.Notify(this, "lights_off");
    }
}
