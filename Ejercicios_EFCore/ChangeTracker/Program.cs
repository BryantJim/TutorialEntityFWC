using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unchanged State
            using (var context = new SchoolContext())
            {
                var student = context.Students.First();
                DisplayStates(context.ChangeTracker.Entries());
            }

            //Added State
            using (var context = new SchoolContext())
            {
                context.Add(new Student() { FirstName = "Bill", LastName = "Gates" });

                DisplayStates(context.ChangeTracker.Entries());
            }

            //Modified State
            using (var context = new SchoolContext())
            {
                var student = context.Students.First();
                student.LastName = "LastName changed";

                DisplayStates(context.ChangeTracker.Entries());
            }

            //Deleted State
            using (var context = new SchoolContext())
            {
                var student = context.Students.First();
                context.Students.Remove(student);

                DisplayStates(context.ChangeTracker.Entries());
            }

            //Detached State
            var disconnectedEntity = new Student() { StudentId = 1, FirstName = "Bill" };

            using (var context = new SchoolContext())
            {
                Console.Write(context.Entry(disconnectedEntity).State);
            }
        }

        private static void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name}," +
                    $"State: { entry.State.ToString()} " +
                    $"");
            }
        }
    }
}
