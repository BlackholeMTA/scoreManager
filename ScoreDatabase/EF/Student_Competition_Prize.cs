namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Competition_Prize
    {
        public int? Competition_Prize_Id { get; set; }

        public int? Student_Major_Class_Id { get; set; }

        [StringLength(8)]
        public string Student_Id { get; set; }

        [Key]
        public int SCP_Id { get; set; }

        public virtual COMPETITION_PRIZE COMPETITION_PRIZE { get; set; }

        public virtual Student_Major_Class Student_Major_Class { get; set; }
    }
}
