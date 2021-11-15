namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_E_Sub
    {
        public int? Entrance_Subject_Id { get; set; }

        public int? Student_Major_Class_Id { get; set; }

        public double? Student_E_Sub_Point { get; set; }

        [Key]
        public int SES_Id { get; set; }

        public virtual ENTRANCE_SUBJECT ENTRANCE_SUBJECT { get; set; }

        public virtual Student_Major_Class Student_Major_Class { get; set; }
    }
}
