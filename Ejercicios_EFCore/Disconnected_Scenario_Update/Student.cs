using System;
using System.Collections.Generic;
using System.Text;

namespace Disconnected_Scenario_Update
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public StudentAddress Address { get; set; }
    }
}
