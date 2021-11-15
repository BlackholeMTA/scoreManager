namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Course_Group_E_Sub
    {
        [StringLength(10)]
        public string Group_E_Subject_Id { get; set; }

        [StringLength(10)]
        public string Training_programme_course_Id { get; set; }

        public double? Course_Group_E_Sub_F_Point { get; set; }

        [Column(TypeName = "ntext")]
        public string Course_Group_E_Sub_Add_Condi { get; set; }

        [Key]
        public int CGES_Id { get; set; }

        public virtual GROUP_E_SUBJECT GROUP_E_SUBJECT { get; set; }

        public virtual TRAINING_PROGRAMME_COURSE TRAINING_PROGRAMME_COURSE { get; set; }
    }
}
