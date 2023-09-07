namespace MapReducePattern
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Enumerable.Range(1, 100).ToList();

            // Map phase
            var squaredNumbers = numbers.AsParallel().Select(x => x * x);

            // Reduce phase
            int sum = squaredNumbers.Sum();

            Console.WriteLine($"Sum of squares: {sum}");
        }
    }

}