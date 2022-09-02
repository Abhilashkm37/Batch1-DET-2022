using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class generation
    {
        static void Main()
        { }
            /*string[] emptyStr = { };
            int[] emptyInt = { };
            string[] words = { "one", "two", "three" };

            var resultStr = emptyStr.DefaultIfEmpty(); // Default is null for string

            var resultInt = emptyInt.DefaultIfEmpty(); // Default is 0 for int

            var resultWords = words.DefaultIfEmpty(); // Not empty, so words array is just copied

            Console.WriteLine("resultStr has one element with a value of null:");
            Console.WriteLine(resultStr.Count() == 1 && resultStr.First() == null);

            Console.WriteLine("resultInt has one element with a value of 0:");
            Console.WriteLine(resultInt.Count() == 1 && resultInt.First() == 0);

            Console.WriteLine("resultWords has same content as words array:");
            Console.WriteLine(resultWords.SequenceEqual(words));*/


            /*var empty = Enumerable.Empty<string>();
            // To make sequence into an array use empty.ToArray()

            Console.WriteLine("Sequence is empty:");
            Console.WriteLine(empty.Count() == 0);*/


            /*var result = Enumerable.Range(0, 5);

            Console.WriteLine("Counting from 0 to 5:");
            foreach (int number in result)
                Console.WriteLine(number);*/


            /*string word = "Nancy Fancy";

            var result = Enumerable.Repeat(word, 5);

            Console.WriteLine("String is repeated 5 times:");
            foreach (string str in result)
                Console.WriteLine(str);*/

            public class Employee
        {
            public Employee()
            {

            }

            public Employee(int id, string name, string dept)
            {
                this.ID = id;
                this.Name = name;
                this.Dept = dept;

            }

            private static List<Employee> GetListofEmployees()
            {
                List<Employee> emps = new List<Employee>();
                emps.Add(new Employee(1, "John", "Training"));
                emps.Add(new Employee(2, "Mark", "Finance"));
                emps.Add(new Employee(3, "Peter", "Technical"));
                emps.Add(new Employee(4, "Bob", "Technical"));
                emps.Add(new Employee(5, "Robert", "Finance"));
                emps.Add(new Employee(6, "Jason", "Training"));

                return emps;
            }
            public int ID { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }

        }


    }
    }

