namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROFESSIONAL_QUALIFICATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROFESSIONAL_QUALIFICATION()
        {
            TRAINING_PROGRAMME = new HashSet<TRAINING_PROGRAMME>();
        }

        [Key]
        [StringLength(3)]
        public string Professional_qualification_Id { get; set; }

        [StringLength(100)]
        public string Professional_qualification_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAINING_PROGRAMME> TRAINING_PROGRAMME { get; set; }
    }
}
