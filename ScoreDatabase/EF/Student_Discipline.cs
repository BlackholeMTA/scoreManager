namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Discipline
    {
        public int? Discipline_Id { get; set; }

        [StringLength(8)]
        public string Student_Id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Student_Discipline_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Student_Discipline_Begin { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Student_Discipline_End { get; set; }

        public virtual DISCIPLINE DISCIPLINE { get; set; }

        public virtual STUDENT STUDENT { get; set; }
    }
}
