namespace Logger;

public class LogManager
{
    public static ILogMessageHandler ConfigureLogHandlers()
    {
        var infoLogger = new InfoMessageHandler();

        var debugLogger = new DebugMessageHandler();

        var errorLogger = new ErrorMessageHandler();

        infoLogger.SetNextHandler(debugLogger).SetNextHandler(errorLogger);

        return infoLogger;
    }

    public static ILogPublisher ConfigureLogWriters()
    {
        var logPublisher = new LogPublisher();
        var consoleWriter = new ConsoleWriter();

        logPublisher.Register(LogLevel.INFO, consoleWriter);
        logPublisher.Register(LogLevel.DEBUG, consoleWriter);
        logPublisher.Register(LogLevel.ERROR, consoleWriter);

        var fileWriter = new FileWriter();
        logPublisher.Register(LogLevel.DEBUG, fileWriter);
        logPublisher.Register(LogLevel.ERROR, fileWriter);

        return logPublisher;
    }
}
