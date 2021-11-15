namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_CERTIFICATE_SCORE
    {
        public int? Student_Lang_Certificate_Id { get; set; }

        public int? S_Certificate_Score_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? S_Certificate_Score_Begin { get; set; }

        [Column(TypeName = "date")]
        public DateTime? S_Certificate_Score_End { get; set; }

        public double? S_Certificate_Score_Band { get; set; }

        [StringLength(20)]
        public string S_Certificate_Score_Level { get; set; }

        [Key]
        public int S_CS_Id { get; set; }

        public virtual Student_Lang_Certificate Student_Lang_Certificate { get; set; }
    }
}
