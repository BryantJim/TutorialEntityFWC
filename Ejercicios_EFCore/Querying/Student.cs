using System;
using System.Collections.Generic;
using System.Text;

namespace Querying
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
