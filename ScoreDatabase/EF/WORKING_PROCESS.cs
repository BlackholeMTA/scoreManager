namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WORKING_PROCESS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Working_process_Id { get; set; }

        public int? Lecturer_Department_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Working_process_Begin { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Working_process_End { get; set; }

        public virtual Lecturer_Department Lecturer_Department { get; set; }
    }
}
