namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Scholarship_Major
    {
        public int? Scholarship_Id { get; set; }

        public int? Student_Major_Class_Id { get; set; }

        [StringLength(8)]
        public string Student_Id { get; set; }

        [Key]
        public int SSM_Id { get; set; }

        public virtual SCHOLARSHIP SCHOLARSHIP { get; set; }

        public virtual Student_Major_Class Student_Major_Class { get; set; }
    }
}
