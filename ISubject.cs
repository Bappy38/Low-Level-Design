public interface ISubject
{
	void Register(IObserver observer);
	void Unregister();

	void Notify();
}