using System;
using System.Collections.Generic;
using System.Text;

namespace Conventions_one_to_many
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public ICollection<Student> Students { get; set; }//la relacion funciona solo con este
    }
}
