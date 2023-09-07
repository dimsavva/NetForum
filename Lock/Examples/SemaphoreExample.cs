using Locks.Models;

namespace Locks.Examples
{
    internal class SemaphoreExample
    {
        private static Customer Customer = new Customer();
        private static Semaphore semaphore = new Semaphore(2, 4);

        public static void RunThreadsExample()
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread thread = new Thread(RunTask);
                thread.Name = $"Thread{i}";
                thread.Start();
            }
        }

        private static void RunTask()
        {
            var name = Thread.CurrentThread.Name;
            Console.WriteLine($"{name} is waiting");
            try
            {
                semaphore.WaitOne();
                Console.WriteLine($"{name} is running");

                Thread.Sleep(200);
                Customer.AddCustomer(name);
                Console.WriteLine($"{name} is done");
                Customer.Print();
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}
