using Singleton_Pattern.Example;

RunExample();

static void RunExample()
{
    Thread process1 = new Thread(() =>
    {
        var singleton1 = Singleton.GetInstance();
    });

    Thread process2 = new Thread(() =>
    {
        var singleton2 = Singleton.GetInstance();
    });

    process1.Start();
    process2.Start();
}