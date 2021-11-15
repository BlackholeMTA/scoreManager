namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LEADERSHIP_PROCESS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Leadership_process_Id { get; set; }

        public int? Lecturer_majorclass_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Leadership_process_Begin { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Leadership_process_End { get; set; }

        public virtual Lecturer_majorclass Lecturer_majorclass { get; set; }
    }
}
