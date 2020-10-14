using System;
using System.Collections.Generic;
using System.Text;

namespace Fluent_API_one_to_many
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CurrentGradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
