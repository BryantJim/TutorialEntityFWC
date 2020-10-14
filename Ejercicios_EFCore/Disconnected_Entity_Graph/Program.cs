using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;

namespace Disconnected_Entity_Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            //Attach
            var stud = new Student()
            {
                Name = "Bill",
                Address = new StudentAddress()
                {
                    StudentAddressId = 1,
                    City = "Seattle",
                    Country = "USA"
                },
                StudentCourses = new List<StudentCourse>() {
                    new StudentCourse(){  Course = new Course(){ CourseName = "Machine Language" } },
                    new StudentCourse(){  Course = new Course(){  CourseId = 2 } } 
                }
            };

            var context = new SchoolContext();
            context.Attach(stud).State = EntityState.Added;

            DisplayStates(context.ChangeTracker.Entries());

            //Entry
            var student = new Student()
            {
                Name = "Bill",
                Address = new StudentAddress()
                {
                    StudentAddressId = 1,
                    City = "Seattle",
                    Country = "USA"
                },
                StudentCourses = new List<StudentCourse>() {
                    new StudentCourse(){  Course = new Course(){ CourseName="Machine Language" } },
                    new StudentCourse(){  Course = new Course(){  CourseId=2 } }
                }
            };

            context = new SchoolContext();
            context.Entry(student).State = EntityState.Modified;

            DisplayStates(context.ChangeTracker.Entries());

            //Add
            student = new Student()
            {
                StudentId = 1,
                Name = "Bill",
                Address = new StudentAddress()
                {
                    StudentAddressId = 1,
                    City = "Seattle",
                    Country = "USA"
                },
                StudentCourses = new List<StudentCourse>() {
                new StudentCourse(){  Course = new Course(){ CourseName="Machine Language" } },
                new StudentCourse(){  Course = new Course(){  CourseId=2 } } 
            }
            };

            context = new SchoolContext();
            context.Students.Add(student);

            DisplayStates(context.ChangeTracker.Entries());

            //Update
            student = new Student()
            {
                StudentId = 1,
                Name = "Bill",
                Address = new StudentAddress()
                {
                    StudentAddressId = 1,
                    City = "Seattle",
                    Country = "USA"
                },
                StudentCourses = new List<StudentCourse>() {
                new StudentCourse(){  Course = new Course(){ CourseName="Machine Language" } },
                new StudentCourse(){  Course = new Course(){  CourseId=2 } }
            }
            };

            context = new SchoolContext();
            context.Update(student);

            DisplayStates(context.ChangeTracker.Entries());

            //Remove
            student = new Student()
            {
                StudentId = 1,
                Name = "Bill",
                Address = new StudentAddress()
                {
                    StudentAddressId = 1,
                    City = "Seattle",
                    Country = "USA"
                },
                StudentCourses = new List<StudentCourse>() {
                    new StudentCourse(){  Course = new Course(){ CourseName="Machine Language" } },
                    new StudentCourse(){  Course = new Course(){  CourseId=2 } }
                }
            };

            context = new SchoolContext();
            context.Remove(student);

            DisplayStates(context.ChangeTracker.Entries());
        }

        private static void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name}," +
                    $"State: { entry.State.ToString()}" +
                    $"");
            }
        }
    }
}
