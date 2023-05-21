using Observer_Pattern.Example___1;
using Observer_Pattern.Example___2;

RunExample2();

static void RunExample1()
{
    var greenSubscriber = new GreenColorSubscriber();
    var redSubscriber = new RedColorSubscriber();

    var colorPublisher = new ColorPublisher();
    colorPublisher.Register(greenSubscriber);
    colorPublisher.Register(redSubscriber);

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Publish new color: ");
        var color = Int32.Parse(Console.ReadLine());
        switch (color)
        {
            case 0:
                colorPublisher.Color = Color.Red;
                break;
            case 1:
                colorPublisher.Color = Color.Green;
                break;
            case 2:
                colorPublisher.Color = Color.Blue;
                break;
        }
    }
}


///
/// C# has two powerful interfaces that are designed particularly to
/// implement Observer pattern. They are IObserver<T> and IObservable<T>.
/// For an object to be a Provider/Publisher, it has to implement IObservable<T>
/// While to be a Subscriber, it has to implement IObserver<T>
/// Here, T is the notification object sent from Publisher to Subscribers
/// 
/// Let's say we are developing a submission system for a company where
/// applicants can apply for jobs. So, we want to notify HRSpecialist
/// whenever a new applicant applies for a job.
///
static void RunExample2()
{
    var observer1 = new HRSpecialist("Disha");
    var observer2 = new HRSpecialist("Sadia");

    var provider = new ApplicationsHandler();

    observer1.Subscribe(provider);
    observer2.Subscribe(provider);

    provider.AddApplication(new(1, "Saddam"));
    provider.AddApplication(new(2, "Yousuf"));

    observer1.ListApplications();
    observer2.ListApplications();

    observer1.Unsubscribe();
    Console.WriteLine();
    Console.WriteLine($"{observer1.Name} unsubscribed");
    Console.WriteLine();

    provider.AddApplication(new(3, "Sofia"));

    observer1.ListApplications();
    observer2.ListApplications();

    Console.WriteLine();
    provider.CloseApplications();
}