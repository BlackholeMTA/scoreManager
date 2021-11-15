namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACULTY")]
    public partial class FACULTY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACULTY()
        {
            DEPARTMENTs = new HashSet<DEPARTMENT>();
            MAJORs = new HashSet<MAJOR>();
        }

        [Key]
        [StringLength(4)]
        public string Faculty_Id { get; set; }

        [StringLength(100)]
        public string Faculty_Name { get; set; }

        [StringLength(200)]
        public string Faculty_Address { get; set; }

        [StringLength(200)]
        public string Faculty_Email { get; set; }

        [StringLength(20)]
        public string Faculty_Phonenumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPARTMENT> DEPARTMENTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAJOR> MAJORs { get; set; }
    }
}
