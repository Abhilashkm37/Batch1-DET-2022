using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class EmployeeLinQ

    {
        
        
            public EmployeeLinQ()
            {

            }

            public EmployeeLinQ(int id, string name, string dept)
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

    internal class Employee
    {
        private int v1;
        private string v2;
        private string v3;

        public Employee(int v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}

