using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Newprocedure
    {
        public static void Main()
        {
            CallStoredProcwithSQLParamater_insert();
        }
        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new TrainingContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 2977
                        },

                         new SqlParameter() {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Abhilash"},

                          new SqlParameter() {
                            ParameterName = "@job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Salesman"},

                          new SqlParameter() {
                            ParameterName = "@mgr",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "7698"},

                           new SqlParameter() {
                            ParameterName = "@hire",
                            SqlDbType =  System.Data.
                            SqlDbType.Date,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "09/05/2022"},

                            new SqlParameter() {
                            ParameterName = "@sal",
                            SqlDbType =  System.Data.
                            SqlDbType.Decimal,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 30000},

                             new SqlParameter() {
                            ParameterName = "@comm",
                            SqlDbType =  System.Data.
                            SqlDbType.Decimal,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 20},

                              new SqlParameter() {
                            ParameterName = "@deptno",
                            SqlDbType =  System.Data.
                            SqlDbType.Decimal,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 10},

                       };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("AddEmployee @empno, @ename, @job, @mgr, @hire, @sal, @comm, @deptno", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                throw;
            }


            Console.WriteLine("update successful");

        }
    }
}