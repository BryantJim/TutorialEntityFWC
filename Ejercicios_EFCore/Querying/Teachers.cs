using System;
using System.Collections.Generic;
using System.Text;

namespace Querying
{
    public class Teachers
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
