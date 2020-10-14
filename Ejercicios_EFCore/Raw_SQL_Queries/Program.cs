using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Raw_SQL_Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolContext();

            var students = context.Students
                              .FromSqlRaw("Select * from Students where Name = 'Bill'")
                              .ToList();

            string name = "Bill";

            students = context.Students
                            .FromSqlRaw($"Select * from Students where Name = '{name}'")
                            .ToList();


            students = context.Students
                            .FromSqlRaw("Select * from Students where Name = '{0}'", name)
                            .ToList();


            students = context.Students
                            .FromSqlRaw("Select * from Students where Name = '{0}'", name)
                            .OrderBy(s => s.StudentId)
                            .ToList();
        }
    }
}
