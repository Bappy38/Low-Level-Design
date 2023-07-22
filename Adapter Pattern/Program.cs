using Adapter_Pattern.Example;

static void RunExample()
{
    Adaptee adaptee = new Adaptee();
    ITarget target = new Adapter(adaptee);

    Console.WriteLine(target.GetRequest());
}

RunExample();