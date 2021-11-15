namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Major_Class_Term
    {
        [StringLength(6)]
        public string Major_Class_Id { get; set; }

        [StringLength(5)]
        public string Term_Id { get; set; }

        public int? Major_Class_Term_Year { get; set; }

        public int? Student_Year { get; set; }

        [Key]
        public int MCT_Id { get; set; }

        public virtual MAJOR_CLASS MAJOR_CLASS { get; set; }

        public virtual TERM TERM { get; set; }
    }
}
