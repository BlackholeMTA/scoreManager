namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TERM")]
    public partial class TERM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TERM()
        {
            CLASSes = new HashSet<CLASS>();
            Major_Class_Term = new HashSet<Major_Class_Term>();
        }

        [Key]
        [StringLength(5)]
        public string Term_Id { get; set; }

        [StringLength(50)]
        public string Term_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLASS> CLASSes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Major_Class_Term> Major_Class_Term { get; set; }
    }
}
