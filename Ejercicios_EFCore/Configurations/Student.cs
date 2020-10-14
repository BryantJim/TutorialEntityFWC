using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Configurations
{
    [Table("StudentInfo")]
    public class Student
    {
        public Student() { }

        [Key]
        public int SID { get; set; }

        [Column("Name", TypeName = "ntext")]
        [MaxLength(20)]
        public string StudentName { get; set; }

        [NotMapped]
        public int? Age { get; set; }


        public int StdId { get; set; }

        [ForeignKey("StdId")]
        public virtual Standard Standard { get; set; }
    }

    public class Standard
    {
        [Key]
        public int StdId { get; set; }
    }
}
