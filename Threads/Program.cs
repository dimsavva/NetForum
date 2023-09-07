namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(RunTask);
            t1.Name = "Thread1";

            Thread t2 = new Thread(RunTask);
            t2.Name = "Thread2";

            t1.Start();
            t2.Start();
        }

        private static void RunTask()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is running");
        }
    }
}
