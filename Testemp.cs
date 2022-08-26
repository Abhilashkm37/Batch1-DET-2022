using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2
{
    internal class Testemp
    {
        public static void Main()
        {
            Emp e = new Emp(5050, "Abhilash", new DateOnly(2020, 8, 1));
            Console.WriteLine($"Years of experience{e.GetYearsofExp()}");

        }
    }
}
