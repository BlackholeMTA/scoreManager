namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Subject_Major_Class
    {
        public int? Student_Major_Class_Id { get; set; }

        [StringLength(8)]
        public string Subject_Id { get; set; }

        public decimal? AveragePoint { get; set; }

        public decimal? AvgPoint10 { get; set; }

        public int? Status { get; set; }

        public int? NumberOfCredits { get; set; }

        public bool? Acceptable { get; set; }

        [StringLength(5)]
        public string AvgPointbyLetter { get; set; }

        [Key]
        public int SSMC_Id { get; set; }

        public virtual Student_Major_Class Student_Major_Class { get; set; }

        public virtual SUBJECT SUBJECT { get; set; }
    }
}
