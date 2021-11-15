namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STUDENT")]
    public partial class STUDENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STUDENT()
        {
            Student_Class = new HashSet<Student_Class>();
            Student_Discipline = new HashSet<Student_Discipline>();
            Student_Lang_Certificate = new HashSet<Student_Lang_Certificate>();
            Student_Major_Class = new HashSet<Student_Major_Class>();
        }

        [Key]
        [StringLength(8)]
        public string Student_Id { get; set; }

        [StringLength(100)]
        public string Student_Name { get; set; }

        [StringLength(10)]
        public string Student_Gender { get; set; }

        [StringLength(200)]
        public string Student_PlaceofOrigin { get; set; }

        [StringLength(100)]
        public string Student_Email { get; set; }

        [StringLength(20)]
        public string Student_Phonenumber { get; set; }

        [StringLength(100)]
        public string Student_HighSchool { get; set; }

        [StringLength(20)]
        public string Student_IDcardnumber { get; set; }

        [StringLength(20)]
        public string Student_Passport_Number { get; set; }

        public int? Student_HS_GraduationYear { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Student_DateofBirth { get; set; }

        [StringLength(50)]
        public string Student_Nationality { get; set; }

        [StringLength(20)]
        public string Student_Religion { get; set; }

        [Column(TypeName = "image")]
        public byte[] Student_Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Class> Student_Class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Discipline> Student_Discipline { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Lang_Certificate> Student_Lang_Certificate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Major_Class> Student_Major_Class { get; set; }
    }
}
