namespace ForkJoinPattern
{
    class Program
    {
        static void Main()
        {
            Task task1 = Task.Run(() => DoWork("Task 1"));
            Task task2 = Task.Run(() => DoWork("Task 2"));

            Task.WhenAll(task1, task2).Wait();

            Console.WriteLine("Both tasks completed!");
        }

        static void DoWork(string taskName)
        {
            Console.WriteLine($"{taskName} starting...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"{taskName} ending...");
        }

    }
}