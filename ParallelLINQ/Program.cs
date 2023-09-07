namespace ParallelLINQ
{
    class Program
    {
        static void Main()
        {
            var numbers = Enumerable.Range(0, 100);
            var parallelQuery = from num in numbers.AsParallel()
                                where num % 2 == 0
                                select num;

            parallelQuery.ForAll(e => Console.WriteLine(e));

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();

        }
    }

}