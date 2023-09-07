namespace ParallelLoops
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Enumerable.Range(1, 100).ToArray();

            Parallel.For(0, numbers.Length, i =>
            {
                Console.WriteLine($"Processing number: {numbers[i]}");
            });
        }

    }
}