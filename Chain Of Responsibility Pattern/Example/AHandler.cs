namespace Chain_Of_Responsibility_Pattern.Example;

/// <summary>
/// The default chaining behavior can be implemented inside a base handler class.
/// </summary>

public abstract class AHandler : IHandler
{
    private IHandler _nextHandler;

    /**
    Returning a handler from here will let us link handlers in a convenient way like this:
    monkey.SetNext(squirrel).SetNext(dog);
    **/
    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual object Handle(object request)
    {
        if (_nextHandler != null)
        {
            return _nextHandler.Handle(request);
        }
        return null;
    }
}
