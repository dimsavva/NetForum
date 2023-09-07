namespace ValueTask
{
    internal class Program
    {
        static async Task Main()
        {
            int result = await ComputeValueAsync();
            Console.WriteLine($"Result: {result}");
        }

        static ValueTask<int> ComputeValueAsync()
        {
            return new ValueTask<int>(42); // Simulating a fast-path completion
        }

    }
}