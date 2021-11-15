namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Course_Optionalsub
    {
        public int? Student_Major_Class_Id { get; set; }

        [StringLength(8)]
        public string Subject_Id { get; set; }

        [Key]
        public int SCO_Id { get; set; }

        public int? Semester { get; set; }

        public virtual Student_Major_Class Student_Major_Class { get; set; }

        public virtual SUBJECT SUBJECT { get; set; }
    }
}
