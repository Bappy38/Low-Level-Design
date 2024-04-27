namespace Logger;


/*
    Implementing Chain of Responsibility Pattern
*/

public interface ILogMessageHandler
{
    ILogMessageHandler SetNextHandler(ILogMessageHandler nextHandler);
    void FlushMessage(LogLevel logLevel, string message, ILogPublisher logPublisher);
}

public abstract class ALogMessageHandler : ILogMessageHandler
{
    public ILogMessageHandler _nextHandler;

    public ILogMessageHandler SetNextHandler(ILogMessageHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public virtual void FlushMessage(LogLevel logLevel, string message, ILogPublisher logPublisher)
    {
        if (_nextHandler is null)
            return;
        _nextHandler.FlushMessage(logLevel, message, logPublisher);
    }
}

public class DebugMessageHandler : ALogMessageHandler
{
    public override void FlushMessage(LogLevel logLevel, string message, ILogPublisher logPublisher)
    {
        if (logLevel == LogLevel.DEBUG)
        {
            logPublisher.PublishLog(LogLevel.DEBUG, $"DEBUG: {message}");
        }
        base.FlushMessage(logLevel, message, logPublisher);
    }
}

public class InfoMessageHandler : ALogMessageHandler
{
    public override void FlushMessage(LogLevel logLevel, string message, ILogPublisher logPublisher)
    {
        if (logLevel == LogLevel.INFO)
        {
            logPublisher.PublishLog(LogLevel.INFO, $"INFO: {message}");
        }
        base.FlushMessage(logLevel, message, logPublisher);
    }
}

public class ErrorMessageHandler : ALogMessageHandler
{
    public override void FlushMessage(LogLevel logLevel, string message, ILogPublisher logPublisher)
    {
        if (logLevel == LogLevel.ERROR)
        {
            logPublisher.PublishLog(LogLevel.ERROR, $"ERROR: {message}");
        }
        base.FlushMessage(logLevel, message, logPublisher);
    }
}