using System;
using System.Linq;

namespace Saving_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var std = new Student()
                {
                    FirstName = "Bill",
                    LastName = "Gates"
                };
                context.Students.Add(std);

                context.SaveChanges();
            }

            using (var context = new SchoolContext())
            {
                var std = context.Students.First<Student>();
                std.FirstName = "Steve";
                context.SaveChanges();
            }

            using (var context = new SchoolContext())
            {
                var std = context.Students.First<Student>();
                context.Students.Remove(std);

                context.SaveChanges();
            }
        }
    }
}
