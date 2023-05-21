namespace Observer_Pattern.Example___2;

/// <summary>
/// It's a subscriber
/// </summary>
public class HRSpecialist : IObserver<Application>
{
    private IDisposable _cancellation;

    public string Name { get; set; }
    public List<Application> Applications { get; set; }

    public HRSpecialist(string name)
    {
        Name = name;
        Applications = new();
    }

    public void ListApplications()
    {
        if (Applications.Any())
            foreach (var app in Applications)
                Console.WriteLine($"Hey, {Name}! {app.ApplicantName} has just applied for job no. {app.JobId}");
        else
            Console.WriteLine($"Hey, {Name}! No applications yet.");
    }

    public virtual void Subscribe(ApplicationsHandler provider)
    {
        _cancellation = provider.Subscribe(this);
    }
    public virtual void Unsubscribe()
    {
        _cancellation.Dispose();
        Applications.Clear();
    }

    public void OnCompleted()
    {
        Console.WriteLine($"Hey, {Name}! We are not accepting any more applications");
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(Application value)
    {
        Applications.Add(value);
    }
}
