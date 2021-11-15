namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CERTIFICATE_BAND
    {
        [Key]
        [StringLength(20)]
        public string Certificate_Score_Id { get; set; }

        [StringLength(20)]
        public string Lecturer_Lang_Certificate_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Certificate_Score_Begin { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Certificate_Score_End { get; set; }

        public double? Certificate_Score_Bandscore { get; set; }

        [StringLength(5)]
        public string Certificate_Score_Level { get; set; }

        public virtual Lecturer_L_Certificate Lecturer_L_Certificate { get; set; }
    }
}
