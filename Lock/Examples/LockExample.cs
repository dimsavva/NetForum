using Locks.Models;

namespace Locks.Examples
{
    internal class LockExample
    {
        private static Customer Customer = new Customer();
        private static object lockObj = new object();

        public static void RunThreadsExample()
        {
            for (int i = 1; i <= 10; i++)
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
            lock (lockObj)
            {
                Console.WriteLine($"{name} is running");

                Thread.Sleep(200);
                Customer.AddCustomer(name);
                Console.WriteLine($"{name} is done");
                Customer.Print();
            }
        }
    }
}
