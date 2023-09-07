using System;
using System.Numerics;

namespace SIMD
{
    class Program
    {
        static void Main()
        {
            int[] values1 = new int[Vector<int>.Count];
            int[] values2 = new int[Vector<int>.Count];

            // Fill the arrays with example values.
            for (int i = 0; i < Vector<int>.Count; i++)
            {
                values1[i] = i + 1; // Just example values; you can change as needed.
                values2[i] = i + 5; // Just example values; you can change as needed.
            }

            Vector<int> vector1 = new Vector<int>(values1);
            Vector<int> vector2 = new Vector<int>(values2);

            Vector<int> result = Vector.Add(vector1, vector2);

            for (int i = 0; i < Vector<int>.Count; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}

