namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Lang_Certificate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student_Lang_Certificate()
        {
            S_CERTIFICATE_SCORE = new HashSet<S_CERTIFICATE_SCORE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Student_Lang_Certificate_Id { get; set; }

        [StringLength(8)]
        public string Student_Id { get; set; }

        [StringLength(20)]
        public string Language_certificate_Name { get; set; }

        public virtual LANGUAGE_CERTIFICATE LANGUAGE_CERTIFICATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_CERTIFICATE_SCORE> S_CERTIFICATE_SCORE { get; set; }

        public virtual STUDENT STUDENT { get; set; }
    }
}
