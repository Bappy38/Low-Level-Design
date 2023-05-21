namespace Observer_Pattern.Example___2;

/// <summary>
/// It's the notification object sent from the Publisher to it's subscribers
/// </summary>
public class Application
{
    public int JobId { get; set; }
    public string ApplicantName { get; set; }

    public Application(int jobId, string applicantName)
    {
        JobId = jobId;
        ApplicantName = applicantName;
    }
}
