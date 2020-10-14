using System;
using System.Collections.Generic;
using System.Text;

namespace Fluent_API_one_to_many
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
