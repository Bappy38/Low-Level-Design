namespace Logger;

/*
    Implementing Observer Pattern
*/

public interface ILogWriter
{
    void WriteMessage(string message);
}

public class ConsoleWriter : ILogWriter
{
    public void WriteMessage(string message)
    {
        Console.WriteLine($"Writing to Console => {message}");
    }
}

public class FileWriter : ILogWriter
{
    public void WriteMessage(string message)
    {
        Console.WriteLine($"Writing to File => {message}");
    }
}

public interface ILogPublisher
{
    void Register(LogLevel logLevel, ILogWriter writer);
    void Unregister(LogLevel logLevel, ILogWriter writer);
    void PublishLog(LogLevel logLevel, string message);
}

public class LogPublisher : ILogPublisher
{
    private Dictionary<LogLevel, List<ILogWriter>> logObserversDict;

    public LogPublisher()
    {
        this.logObserversDict = new Dictionary<LogLevel, List<ILogWriter>>();
    }

    public void PublishLog(LogLevel logLevel, string message)
    {
        if (!logObserversDict.ContainsKey(logLevel))
        {
            return;
        }

        foreach(var logWriter in logObserversDict[logLevel])
        {
            logWriter.WriteMessage(message);
        }
    }

    public void Register(LogLevel logLevel, ILogWriter writer)
    {
        if (!logObserversDict.ContainsKey(logLevel))
        {
            var logWriters = new List<ILogWriter> { writer };
            logObserversDict[logLevel] = logWriters;
            return;
        }

        logObserversDict[logLevel].Add(writer);
    }

    public void Unregister(LogLevel logLevel, ILogWriter writer)
    {
        if (!logObserversDict.ContainsKey(logLevel))
        {
            return;
        }
        logObserversDict[logLevel].Remove(writer);
    }
}