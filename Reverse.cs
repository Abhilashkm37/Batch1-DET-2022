using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Reverse
    {
        static void Main()
        {
            char[] characters = { 'M', 'I', 'C', 'H', 'A', 'E' , 'L' };

            var result = characters.Reverse();

            Console.WriteLine("Characters in reverse order:");
            foreach (char character in result)
                Console.WriteLine(character);
        }
    }

    //internal class Descendingnumbers
    //{
    //    static void Main()
    //    {
    //        string[] names = { "Abhilash", "Jeevan", "Vasu" };

    //        var result = names.OrderByDescending(n => n);

    //        Console.WriteLine("Descending ordered list of names:");
    //        foreach (string name in result)
    //            Console.WriteLine(name);
    //    }
    //}


    //internal class simplenumbers
    //{
    //    static void Main()
    //    {
    //        int[] numbers = { 7, 9, 5 };

    //        var result = numbers.OrderBy(n => n);

    //        Console.WriteLine("Ordered list of numbers:");
    //        foreach (int number in result)
    //            Console.WriteLine(number);
    //    }
    //}


}
