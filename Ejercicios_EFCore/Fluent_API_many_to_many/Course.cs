using System;
using System.Collections.Generic;
using System.Text;

namespace Fluent_API_many_to_many
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
