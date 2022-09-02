using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Aggregate
    {
        private static void Main()
        {
            /*var numbers = new int[] { 4, 5, 7, 8, 3};

            var result = numbers.Aggregate((a, b) => a * b);

            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result);*/


            /*var numbers = new int[] { 9, 7, 6};

            var result = numbers.Aggregate(10, (a, b) => a + b);

            Console.WriteLine("Aggregated numbers by addition with a seed of 10:");
            Console.WriteLine(result);*/

            /*int[] numbers = { 25, 25, 25, 25 };

            var result = numbers.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result);*/

            /*string[] names = { "Emraan Hashmi", "John abraham", "Salman", "Shah rukh Khan", "Siddarth Malhotra" };

            var result = names.Count();

            Console.WriteLine("Counting names gives:");
            Console.WriteLine(result);*/


            // Create array which is 5 elements larger than Int32.MaxValue
            /*var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 10));

            Int64 result = largeArr.LongCount();

            Console.WriteLine("Counting largeArr elements:");
            Console.WriteLine(result);*/

            /*int[] numbers = { 2, 8, 5, 6, 1 };

            var result = numbers.Max();

            Console.WriteLine("Highest number is:");
            Console.WriteLine(result);*/

            /*int[] numbers = { 6, 9, 3, 7, 5 };

            var result = numbers.Min();

            Console.WriteLine("Lowest number is:");
            Console.WriteLine(result);*/

            int[] numbers = { 2, 5, 10 };

            var result = numbers.Sum();

            Console.WriteLine("Summing the numbers yields:");
            Console.WriteLine(result);

        }
    }
}
