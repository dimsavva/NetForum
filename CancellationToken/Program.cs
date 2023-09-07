using System;
using System.Threading;
using System.Threading.Tasks;

    class Program
    {
        static async Task Main()
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            Task task = DoWork(token);

            Console.WriteLine("Press any key to cancel the operation...");
            Console.ReadKey();
            cancellationTokenSource.Cancel();

            try
            {
                await task;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation was cancelled!");
            }
        }

        static async Task DoWork(CancellationToken token)
        {
            for (int i = 0; i < 5; i++)
            {
                token.ThrowIfCancellationRequested();
                Console.WriteLine($"Working... {i}");
                await Task.Delay(1000);
            }
        }

    }
