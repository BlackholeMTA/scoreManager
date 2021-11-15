namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Class
    {
        [StringLength(8)]
        public string Student_Id { get; set; }

        [StringLength(8)]
        public string Class_Id { get; set; }

        public decimal? Student_Class_Point1 { get; set; }

        public decimal? Student_Class_Point2 { get; set; }

        public decimal? Student_Class_Point3 { get; set; }

        public decimal? Point1_Coefficient { get; set; }

        public decimal? Poinr2_Coefficient { get; set; }

        public decimal? Point3_Coefficient { get; set; }

        public decimal? Student_Class_Averagepoint { get; set; }

        public decimal? Student_Class_4_Avgpoint { get; set; }

        public int? Student_Major_Class_Id { get; set; }

        public bool? Countas { get; set; }

        [StringLength(5)]
        public string AvgPointbyLetter { get; set; }

        public int? Student_Class_Status { get; set; }

        [Key]
        public int STT { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public virtual CLASS CLASS { get; set; }

        public virtual STUDENT STUDENT { get; set; }

        public virtual Student_Major_Class Student_Major_Class { get; set; }
    }
}
