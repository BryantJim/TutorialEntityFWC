using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Querying
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolContext();
            var studentsWithSameName = context.Students
                                              .Where(s => s.FirstName == GetName())
                                              .ToList();

            var studentWithGrade = context.Students
                           .Where(s => s.FirstName == "Bill")
                           .Include(s => s.Grade)
                           .FirstOrDefault();

            var studentWithGrade2 = context.Students
                        .Where(s => s.FirstName == "Bill")
                        .Include("Grade")
                        .FirstOrDefault();

            var studentWithGrade3 = context.Students
                        .FromSqlRaw("Select * from Students where FirstName ='Bill'")
                        .Include(s => s.Grade)
                        .FirstOrDefault();

            var studentWithGrade4 = context.Students.Where(s => s.FirstName == "Bill")
                        .Include(s => s.Grade)
                        .Include(s => s.StudentCourses)
                        .FirstOrDefault();

            var student = context.Students.Where(s => s.FirstName == "Bill")
                        .Include(s => s.Grade)
                            .ThenInclude(g => g.Teachers)
                        .FirstOrDefault();

            var stud = context.Students.Where(s => s.FirstName == "Bill")
                        .Select(s => new
                        {
                            Student = s,
                            Grade = s.Grade,
                            GradeTeachers = s.Grade.Teachers
                        })
                        .FirstOrDefault();
        }

        public static string GetName()
        {
            return "Bill";
        }
    }
}
