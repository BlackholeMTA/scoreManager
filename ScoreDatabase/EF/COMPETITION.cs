namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMPETITION")]
    public partial class COMPETITION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPETITION()
        {
            COMPETITION_PRIZE = new HashSet<COMPETITION_PRIZE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Competition_Id { get; set; }

        [StringLength(200)]
        public string Competition_Name { get; set; }

        public int? Competition_Year { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPETITION_PRIZE> COMPETITION_PRIZE { get; set; }
    }
}
