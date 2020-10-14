using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Disconnected_Scenario_Delete
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student()
            {
                StudentId = 1
            };

            using (var context = new SchoolContext())
            {
                context.Remove<Student>(student);

                context.SaveChanges();
            }

            student = new Student()
            {
                StudentId = 50
            };

            using (var context = new SchoolContext())
            {
                try
                {
                    context.Remove<Student>(student);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw new Exception("Record does not exist in the database");
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            IList<Student> students = new List<Student>() {
                new Student(){ StudentId = 1 },
                new Student(){ StudentId = 2 },
                new Student(){ StudentId = 3 },
                new Student(){ StudentId = 4 }
            };

            using (var context = new SchoolContext())
            {
                context.RemoveRange(students);

                context.SaveChanges();
            }
        }
    }
}
