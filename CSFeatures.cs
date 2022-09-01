using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface CSFeatures
    {
        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($"Hi {name}"); };

            Action<string, string> action1 = (string name, string place) => { Console.WriteLine($"Hi {name}, am in {place}"); };
            Action<string, string, string> action2 = (string name, string place, string company) => { Console.WriteLine($"Hi {name}, am in {place}, work in {company}"); };

            action.Invoke("Abhilash");
            action1.Invoke("Abhilash", " Bangalore");
            action2.Invoke("Abhilash", "Bangalore", "Sonata Software");


            Action<int, string, string> PrintEmp = (int id, string name, string email) => { Console.WriteLine($"Hi {id}, I am {name}, my {email}"); };




            PrintEmp.Invoke(22763, "Abhilash", "Abhilash.km");
        }
    }
}