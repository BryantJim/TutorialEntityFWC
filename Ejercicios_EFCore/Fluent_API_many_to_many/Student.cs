using System;
using System.Collections.Generic;
using System.Text;

namespace Fluent_API_many_to_many
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
