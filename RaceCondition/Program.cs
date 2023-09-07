namespace RaceCondition
{
    internal class Program
    {
        private static Customer Customer = new Customer();

        static void Main(string[] args)
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
            Console.WriteLine($"{name} is running");
            Thread.Sleep(200);
            Customer.AddCustomer(name);
            Console.WriteLine($"{name} is done");
            Customer.Print();
        }
    }
}
