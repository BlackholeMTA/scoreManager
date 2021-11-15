namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subjects_Condi_Subjects
    {
        [StringLength(8)]
        public string Subject_Id { get; set; }

        [StringLength(8)]
        public string Conditional_subject { get; set; }

        [Key]
        public int SCS_Id { get; set; }

        public virtual SUBJECT SUBJECT { get; set; }

        public virtual SUBJECT SUBJECT1 { get; set; }
    }
}
