namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subject_Exam_Form
    {
        public int? Exam_form_Id { get; set; }

        [StringLength(8)]
        public string Subject_Id { get; set; }

        [Key]
        public int SEF_Id { get; set; }

        public virtual EXAM_FORM EXAM_FORM { get; set; }

        public virtual SUBJECT SUBJECT { get; set; }
    }
}
