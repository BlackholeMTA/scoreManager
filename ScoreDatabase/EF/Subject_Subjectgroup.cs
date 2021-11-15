namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subject_Subjectgroup
    {
        [StringLength(8)]
        public string Subject_Id { get; set; }

        [StringLength(6)]
        public string Group_Subject_Id { get; set; }

        public bool? Requiredornot { get; set; }

        public int? Semester { get; set; }

        [Key]
        public int SSG_Id { get; set; }

        public virtual GROUP_SUBJECTS GROUP_SUBJECTS { get; set; }

        public virtual SUBJECT SUBJECT { get; set; }
    }
}
