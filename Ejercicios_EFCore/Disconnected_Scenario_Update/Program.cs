using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Disconnected_Scenario_Update
{
    class Program
    {
        static void Main(string[] args)
        {
            var stud = new Student() { StudentId = 1, Name = "Bill" };

            stud.Name = "Steve";

            using (var context = new SchoolContext())
            {
                context.Update<Student>(stud);

                context.SaveChanges();
            }


            var modifiedStudent1 = new Student()
            {
                StudentId = 1,
                Name = "Bill"
            };

            var modifiedStudent2 = new Student()
            {
                StudentId = 3,
                Name = "Steve"
            };

            var modifiedStudent3 = new Student()
            {
                StudentId = 3,
                Name = "James"
            };

            IList<Student> modifiedStudents = new List<Student>()
            {
                modifiedStudent1,
                modifiedStudent2,
                modifiedStudent3
            };

            using (var context = new SchoolContext())
            {
                context.UpdateRange(modifiedStudents);

                context.SaveChanges();
            }


            var newStudent = new Student()
            {
                Name = "Bill"
            };

            var modifiedStudent = new Student()
            {
                StudentId = 1,
                Name = "Steve"
            };

            using (var context = new SchoolContext())
            {
                context.Update<Student>(newStudent);
                context.Update<Student>(modifiedStudent);

                DisplayStates(context.ChangeTracker.Entries());
            }
        }
        private static void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name}, " +
                    $"State: { entry.State.ToString()}" +
                    $"");
            }
        }
    }
}
