using System;
using System.Collections.Generic;
using System.Text;

namespace Conventions_one_to_many
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }//la relacion funciona solo con este
    }
}
