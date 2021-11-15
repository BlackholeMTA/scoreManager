namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Group_E_Sub_E_Sub
    {
        public int? Entrance_Subject_Id { get; set; }

        [StringLength(10)]
        public string Group_E_Subject_Id { get; set; }

        [Key]
        public int GESES_Id { get; set; }

        public virtual ENTRANCE_SUBJECT ENTRANCE_SUBJECT { get; set; }

        public virtual GROUP_E_SUBJECT GROUP_E_SUBJECT { get; set; }
    }
}
