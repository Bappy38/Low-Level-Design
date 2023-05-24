namespace Chain_Of_Responsibility_Pattern.Example;

public class DogHandler : AHandler
{
    public override object Handle(object request)
    {
        if ((request as string) == "Meat")
        {
            return $"Dog: I will eat the {request.ToString()}\n";
        }
        return base.Handle(request);
    }
}
