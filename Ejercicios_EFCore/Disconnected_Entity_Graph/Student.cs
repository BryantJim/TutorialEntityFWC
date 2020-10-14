using System;
using System.Collections.Generic;
using System.Text;

namespace Disconnected_Entity_Graph
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public StudentAddress Address { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
