using System;
using System.Collections.Generic;
using System.Text;

namespace Disconnected_Scenario_Insert
{
    public class StudentAddress
    {
        public int StudentAddressId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public int AddressOfStudentId { get; set; }
        public Student Student { get; set; }
    }
}
