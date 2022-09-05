using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class stored_procedure
    {
        public static void Main()
        
        {
            WithoutPara();
        
            }
        private static void WithoutPara()
        { 
              var ctx = new TrainingContext();

           var employees = ctx.Emps.FromSqlRaw($"AllEmpDetailsWithDeptNo").ToList();


           foreach (var e in employees)
           {
               Console.WriteLine(e.Ename);
           }
        }


    }
}
