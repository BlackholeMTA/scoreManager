namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MAJOR")]
    public partial class MAJOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAJOR()
        {
            TRAINING_PROGRAMME = new HashSet<TRAINING_PROGRAMME>();
        }

        [Key]
        [StringLength(7)]
        public string Major_Id { get; set; }

        [StringLength(100)]
        public string Major_Name { get; set; }

        [StringLength(4)]
        public string Faculty_Id { get; set; }

        public virtual FACULTY FACULTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAINING_PROGRAMME> TRAINING_PROGRAMME { get; set; }
    }
}
