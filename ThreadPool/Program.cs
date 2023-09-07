using System.Diagnostics;

namespace ThreadPooling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Console.WriteLine("Thread Pool Executing");
            stopwatch.Start();
            UsingThreadPool();
            stopwatch.Stop();
            Console.WriteLine($"Time to run using Thread Pool: {stopwatch.ElapsedTicks}");
            stopwatch.Reset();

            Console.WriteLine("Thread only Executing");
            stopwatch.Start();
            UsingThreads();
            stopwatch.Stop();
            Console.WriteLine($"Time to run using ony Threads: {stopwatch.ElapsedTicks}");
        }

        private static void UsingThreadPool()
        {
            for (int i = 1; i <= 6; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(RunTask));
            }
        }

        public static void RunTask(object callback)
        {
        }

        private static void UsingThreads()
        {
            for (int i = 1; i <= 6; i++)
            {
                Thread thread = new Thread(RunTask);
                thread.Name = $"Thread{i}";
                thread.Start();
            }
        }
    }
}
