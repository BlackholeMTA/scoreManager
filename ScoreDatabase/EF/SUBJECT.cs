namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUBJECTS")]
    public partial class SUBJECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUBJECT()
        {
            CLASSes = new HashSet<CLASS>();
            Student_Course_Optionalsub = new HashSet<Student_Course_Optionalsub>();
            Student_Subject_Major_Class = new HashSet<Student_Subject_Major_Class>();
            Subject_Exam_Form = new HashSet<Subject_Exam_Form>();
            Subject_Subjectgroup = new HashSet<Subject_Subjectgroup>();
            Subjects_Condi_Subjects = new HashSet<Subjects_Condi_Subjects>();
            Subjects_Condi_Subjects1 = new HashSet<Subjects_Condi_Subjects>();
        }

        [Key]
        [StringLength(8)]
        public string Subject_Id { get; set; }

        [StringLength(50)]
        public string Subject_Name { get; set; }

        public int? Subject_Numberofcredits { get; set; }

        public int? Subject_Numberofperiods { get; set; }

        [Column(TypeName = "ntext")]
        public string Subject_Target { get; set; }

        [Column(TypeName = "ntext")]
        public string Subject_Content { get; set; }

        [StringLength(6)]
        public string Department_Id { get; set; }

        public bool? AllowOptional { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLASS> CLASSes { get; set; }

        public virtual DEPARTMENT DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Course_Optionalsub> Student_Course_Optionalsub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Subject_Major_Class> Student_Subject_Major_Class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subject_Exam_Form> Subject_Exam_Form { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subject_Subjectgroup> Subject_Subjectgroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subjects_Condi_Subjects> Subjects_Condi_Subjects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subjects_Condi_Subjects> Subjects_Condi_Subjects1 { get; set; }
    }
}
