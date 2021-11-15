namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRAINING_PROGRAMME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRAINING_PROGRAMME()
        {
            TRAINING_PROGRAMME_COURSE = new HashSet<TRAINING_PROGRAMME_COURSE>();
        }

        [Key]
        [StringLength(8)]
        public string Training_programme_Id { get; set; }

        [StringLength(100)]
        public string Training_programme_Name { get; set; }

        [StringLength(20)]
        public string Training_programme_Language { get; set; }

        [StringLength(20)]
        public string Training_programme_Form { get; set; }

        [StringLength(3)]
        public string Professional_qualification_Id { get; set; }

        [StringLength(7)]
        public string Major_Id { get; set; }

        public virtual MAJOR MAJOR { get; set; }

        public virtual PROFESSIONAL_QUALIFICATION PROFESSIONAL_QUALIFICATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAINING_PROGRAMME_COURSE> TRAINING_PROGRAMME_COURSE { get; set; }
    }
}
