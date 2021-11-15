namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LANGUAGE_CERTIFICATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LANGUAGE_CERTIFICATE()
        {
            Lecturer_L_Certificate = new HashSet<Lecturer_L_Certificate>();
            Student_Lang_Certificate = new HashSet<Student_Lang_Certificate>();
        }

        [Key]
        [StringLength(20)]
        public string Language_certificate_Name { get; set; }

        public int? Foreign_Language_Id { get; set; }

        [StringLength(30)]
        public string Foreign_Language_Name { get; set; }

        public virtual FOREIGN_LANGUAGE FOREIGN_LANGUAGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lecturer_L_Certificate> Lecturer_L_Certificate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Lang_Certificate> Student_Lang_Certificate { get; set; }
    }
}
