namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LECTURER")]
    public partial class LECTURER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LECTURER()
        {
            CLASSes = new HashSet<CLASS>();
            Lecturer_Department = new HashSet<Lecturer_Department>();
            Lecturer_majorclass = new HashSet<Lecturer_majorclass>();
            Lecturer_L_Certificate = new HashSet<Lecturer_L_Certificate>();
        }

        [Key]
        [StringLength(10)]
        public string Lecturer_Id { get; set; }

        [StringLength(100)]
        public string Lecturer_Name { get; set; }

        [StringLength(20)]
        public string Lecturer_Phonenumber { get; set; }

        [StringLength(200)]
        public string Lecturer_Email { get; set; }

        [StringLength(100)]
        public string Lecturer_Degree { get; set; }

        [StringLength(100)]
        public string Lecturer_Academicrank { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLASS> CLASSes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lecturer_Department> Lecturer_Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lecturer_majorclass> Lecturer_majorclass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lecturer_L_Certificate> Lecturer_L_Certificate { get; set; }
    }
}
