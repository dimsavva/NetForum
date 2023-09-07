namespace TaskParallelLibrary
{
   class Program
    {
        static void Main()
        {
            Parallel.Invoke(() => Task1(), () => Task2());
            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }

        static void Task1()
        {
            Console.WriteLine("Task 1 starting...");
            // Simulate some work
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Task 1 ending...");
        }

        static void Task2()
        {
            Console.WriteLine("Task 2 starting...");
            // Simulate some work
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Task 2 ending...");
        }
    }
}