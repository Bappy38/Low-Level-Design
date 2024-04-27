namespace Logger;

/*
 * Implementing Singleton Pattern
*/
public class Logger
{
    private static Logger _instance;
    private static ILogPublisher _logPublisher;
    private static ILogMessageHandler _handlerChain;

    private static readonly object _lock = new object();

    private Logger() {}

    public static Logger GetInstance()
    {
        if (_instance is null)
        {
            lock (_lock)
            {
                if (_instance is null)
                {
                    _instance = new Logger();
                    _handlerChain = LogManager.ConfigureLogHandlers();
                    _logPublisher = LogManager.ConfigureLogWriters();
                }
            }
        }
        return _instance;
    }

    public void Info(string message)
    {
        _handlerChain.FlushMessage(LogLevel.INFO, message, _logPublisher);
    }

    public void Debug(string message)
    {
        _handlerChain.FlushMessage(LogLevel.DEBUG, message, _logPublisher);
    }

    public void Error(string message) 
    { 
        _handlerChain.FlushMessage(LogLevel.ERROR, message, _logPublisher);
    }
}
