using System;
using System.Collections.Generic;

namespace Disconnected_Scenario_Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            var std = new Student() { Name = "Bill" };

            using (var context = new SchoolContext())
            {
                context.Add<Student>(std);

                context.SaveChanges();
            }

            //

            var stdAddress = new StudentAddress()
            {
                City = "SFO",
                State = "CA",
                Country = "USA"
            };

            std = new Student()
            {
                Name = "Steve",
                Address = stdAddress
            };
            using (var context = new SchoolContext())
            {
                context.Add<Student>(std);

                context.SaveChanges();
            }

            //

            var studentList = new List<Student>() {
                new Student(){ Name = "Bill" },
                new Student(){ Name = "Steve" }
            };

            using (var context = new SchoolContext())
            {
                context.AddRange(studentList);
                context.SaveChanges();
            }
        }
    }
}
