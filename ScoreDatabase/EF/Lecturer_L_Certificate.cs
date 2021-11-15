namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lecturer_L_Certificate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lecturer_L_Certificate()
        {
            CERTIFICATE_BAND = new HashSet<CERTIFICATE_BAND>();
        }

        [Key]
        [StringLength(20)]
        public string Lecturer_Lang_Certificate_Id { get; set; }

        [StringLength(10)]
        public string Lecturer_Id { get; set; }

        [StringLength(20)]
        public string Language_certificate_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CERTIFICATE_BAND> CERTIFICATE_BAND { get; set; }

        public virtual LANGUAGE_CERTIFICATE LANGUAGE_CERTIFICATE { get; set; }

        public virtual LECTURER LECTURER { get; set; }
    }
}
