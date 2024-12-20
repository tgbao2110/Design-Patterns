public class BaseDevice
{
    protected IMediator _mediator;

    public IMediator Mediator
    {
        get => _mediator;
        set => _mediator = value;
    }

    public BaseDevice(IMediator mediator = null)
    {
        _mediator = mediator;
    }
}
