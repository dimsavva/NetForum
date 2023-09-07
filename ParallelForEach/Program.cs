namespace ParallelForEach
{
    class Program
    {
        static void Main()
        {
            List<string> data = new List<string> { "apple", "banana", "cherry" };
            Parallel.ForEach(data, fruit =>
            {
                Console.WriteLine($"Processing {fruit}");
            });

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();

        }
    }

}