namespace Chain_Of_Responsibility_Pattern.Example;

public class MonkeyHandler : AHandler
{
    public override object Handle(object request)
    {
        if ( (request as string) == "Banana")
        {
            return $"Monkey: I will eat the {request.ToString()}\n";
        }
        return base.Handle(request);
    }
}
