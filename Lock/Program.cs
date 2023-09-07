using Locks.Examples;

namespace Lock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LockExample.RunThreadsExample();
            //MutexExample.RunThreadsExample();
            //MonitorExample.RunThreadsExample();
            //SemaphoreExample.RunThreadsExample();
        }
    }
}
