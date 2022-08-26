using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthday = new DateTime(1992, 10, 02);

            var age = DateTime.Today.Year - birthday.Year;

            if (birthday.Date > DateTime.Today.AddYears(-age)) age--;
            Console.WriteLine("Age = " + age);
            Console.ReadLine();
        }
    }
}