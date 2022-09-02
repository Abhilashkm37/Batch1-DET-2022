using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Conversion
    {
        static void Main()
        {
            /*string[] names = { "Shah Rukh Khan", "Salman Khan", "Emraan Hashmi" };

            var result = names.AsEnumerable();

            Console.WriteLine("Iterating over IEnumerable collection:");
            foreach (var name in result)
                Console.WriteLine(name);*/

            /*List<string> vegetables = new List<string> { "Tomato", "potato", "Onion" };

            var result = vegetables.Cast<string>();

            Console.WriteLine("List of vegetables casted to a simple string array:");
            foreach (string vegetable in result)
                Console.WriteLine(vegetable);*/


            /*object[] objects = { "Kylie Jenner", 31, 5.02, null, "Kendal Jenner" };

             var result = objects.OfType<string>();

            Console.WriteLine("Objects being of type string have the values:");
             foreach (string str in result)
                 Console.WriteLine(str);*/

            /*int[] numbers = { 1, 2, 3, 4 };

            var result = numbers.ToArray();

            Console.WriteLine("New array contains identical values:");
            foreach (int number in result)
                Console.WriteLine(number);*/


            /*int[] numbers = { 1, 2, 3, 4 };

            var result = numbers.ToDictionary(k => k, v => (v % 2) == 1 ? "Odd" : "Even");

            Console.WriteLine("Numbers labeled Odd and Even in dictionary:");
            foreach (var dic in result)
                Console.WriteLine("Value {0} is {1}", dic.Key, dic.Value);*/



            /*string[] names = { "Kim Kardashian", "Taylor Swift", "Nick Jonas" };

            List<string> result = names.ToList();

            Console.WriteLine(String.Format("names is of type: {0}", names.GetType().Name));
            Console.WriteLine(String.Format("result is of type: {0}", result.GetType().Name));*/


            string[] words = { "one", "two", "three", "four", "five", "six", "seven" };

            var result = words.ToLookup(w => w.Length);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(String.Format("Elements with a length of {0}:", i));
                foreach (string word in result[i])
                    Console.WriteLine(word);
            }
        }
    }
}
