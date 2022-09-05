using Batch1_DET_2022.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Emp = Batch1_DET_2022.Models.Emp;

namespace Batch1_DET_2022
{
    class DatabaseFirstApproach
    {


        static void Main(string[] args)
        {
            //DeleteEmployee1();
            //AddEmployee();
            UpdateEmployee();
            Console.ReadLine();
        }
        private static void UpdateEmployee()

        {
            var ctx = new TrainingContext();
            try
            {
               Emp employee=new Emp();
                employee.Empno=7499;
                employee.Ename = "Manu";
                employee.Sal = 40000;
                employee.Deptno = 10;
                employee.Job = "DET";


               ctx.Update(employee);
               ctx.SaveChanges();
               Console.WriteLine("Updated Emp");
          }
           catch (Exception ex)
           {
               Console.WriteLine(ex.InnerException.Message); 
           }





    }
}
}