using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class AssignmanetLinQ
    {
        public static void Main()
        {
            /*string[] names = { "Nobitha", "Bheem", "Jhonson", "Harry", "Pokemon" };

            var name = from n in names
                       where n.Contains('e')
                       select n;

            foreach (string n in name)
                Console.WriteLine(n);*/

            /*string[] capitals = { "John", "Peter", "Jacob", "Harry", "Jackson" };

            var res = capitals.OrderBy(c => c.Length);
            var result = capitals.Skip(4);

            Console.WriteLine("Name which has max no of character length:");
            foreach (string capital in result)
             Console.WriteLine(capital);*/

            /*string[] names = { "Jeevan", "Abhilash", "Yash" };

            var result = names.Reverse();
            foreach (string name in result)

            Console.WriteLine("Reversed Names are :");
            Console.WriteLine(result);*/

            List<string> words = new List<string> { "basket", "blueberry", "Chimpanzee", "Abacus", "banana", "Apple", "Cheese" };


            var wordgroups = words.GroupBy(x => x[0]).Select
                (y => new { firstletter = y.Key, Words = y });

            foreach ( var item in wordgroups )
            {

                Console.WriteLine("words that start with the" +
                    "letter '{0}': ",
                    item.firstletter);
                foreach (var w in item.Words)
                {
                    Console.WriteLine(w);

                }
            }
        }
    }
}
