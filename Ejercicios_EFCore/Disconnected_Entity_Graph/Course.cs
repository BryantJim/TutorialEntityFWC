﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Disconnected_Entity_Graph
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
