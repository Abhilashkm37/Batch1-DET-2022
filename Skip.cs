using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Skip
    {
        static void Main()
        {
            /*string[] words = { "one", "two", "three", "four", "five", "six" };

            var result = words.Skip(4);

            Debug.WriteLine("Skips the first 4 words:");
            foreach (string word in result)
                Debug.WriteLine(word);*/


            string[] words = { "one", "two", "three", "four", "five", "six" };

            var result = words.SkipWhile(w => w.Length == 3);

            Console.WriteLine("Skips words while the condition is met:");
            foreach (string word in result)
                Console.WriteLine(word);
        }
    }
    
}
