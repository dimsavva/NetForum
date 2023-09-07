using System.Threading.Channels;

namespace ThreadingChannels
{
    internal class Program
    {
        static async Task Main()
        {
            var channel = Channel.CreateUnbounded<string>();

            var producer = Task.Run(async () =>
            {
                for (int i = 0; i < 5; i++)
                {
                    await channel.Writer.WriteAsync($"Message {i}");
                    await Task.Delay(500);
                }
                channel.Writer.Complete();
            });

            var consumer = Task.Run(async () =>
            {
                await foreach (var message in channel.Reader.ReadAllAsync())
                {
                    Console.WriteLine($"Received: {message}");
                }
            });

            await Task.WhenAll(producer, consumer);
        }
    }
}