using System;
using System.Linq;

namespace activity2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize an array of integers
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // Use LINQ to query even numbers
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // Print the even numbers
            Console.WriteLine("Even numbers in the array:");
            foreach (int num in numQuery)
            {
                Console.WriteLine(num);
            }

            // Wait for user input before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}