namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEPARTMENT")]
    public partial class DEPARTMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEPARTMENT()
        {
            Lecturer_Department = new HashSet<Lecturer_Department>();
            SUBJECTS = new HashSet<SUBJECT>();
        }

        [Key]
        [StringLength(6)]
        public string Department_Id { get; set; }

        [StringLength(100)]
        public string Department_Name { get; set; }

        [StringLength(200)]
        public string Department_Address { get; set; }

        [StringLength(200)]
        public string Department_Email { get; set; }

        [StringLength(20)]
        public string Department_Phonenumber { get; set; }

        [StringLength(4)]
        public string Faculty_Id { get; set; }

        public virtual FACULTY FACULTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lecturer_Department> Lecturer_Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUBJECT> SUBJECTS { get; set; }
    }
}
