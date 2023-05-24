namespace Chain_Of_Responsibility_Pattern.Example;

public class CatHandler : AHandler
{
    public override object Handle(object request)
    {
        if ((request as string) == "Milk")
        {
            return $"Cat: I will eat the {request.ToString()}\n";
        }
        return base.Handle(request);
    }
}
