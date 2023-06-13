namespace Singleton_Pattern.Example;

/// <summary>
/// This Singleton implementation is called "double check lock". It is safe in
/// multithreaded environment and provides lazy initialization for the Singleton
/// object.
/// </summary>

public class Singleton
{
    private Singleton() 
    {
        Console.WriteLine($"Singleton object initialized...");
    }

    private static Singleton _instance;

    private static readonly object _lock = new object();

    public static Singleton GetInstance() 
    {
        /// This condition is needed to prevent threads stumbling over the lock
        /// once the instance is ready.
        if (_instance == null)
        {
            /// Now, imagine that the program has just been launched. Since there's
            /// no Singleton instance yet, multiple threads can simultaneously pass
            /// the previous condition and reach this point almost at the same 
            /// time. The first of them will acquire lock and will proceed further,
            /// while the rest will wait here.
            lock(_lock)
            {
                /// The first thread acquire the lock, reaches this condition, goes
                /// inside and create the Singleton instance. Once it leaves the
                /// lock block, a thread that might have been waiting for the lock
                /// release may then enter this section. But since the Singleton
                /// filed is already initialized, the thread won't create a new
                /// object.
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
        }
        return _instance;
    }
}
