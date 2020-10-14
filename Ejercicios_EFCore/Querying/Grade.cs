using System;
using System.Collections.Generic;
using System.Text;

namespace Querying
{
    public class Grade
    {
        public int Id { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public IList<Student> Students { get; set; }

        public IList<Teachers> Teachers { get; set; }
    }
}
