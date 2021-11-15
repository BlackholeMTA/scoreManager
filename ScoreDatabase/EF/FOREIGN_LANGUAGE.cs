namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FOREIGN_LANGUAGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FOREIGN_LANGUAGE()
        {
            LANGUAGE_CERTIFICATE = new HashSet<LANGUAGE_CERTIFICATE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Foreign_Language_Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Foreign_Language_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LANGUAGE_CERTIFICATE> LANGUAGE_CERTIFICATE { get; set; }
    }
}
