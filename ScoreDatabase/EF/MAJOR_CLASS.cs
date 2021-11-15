namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAJOR_CLASS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAJOR_CLASS()
        {
            Lecturer_majorclass = new HashSet<Lecturer_majorclass>();
            Major_Class_Term = new HashSet<Major_Class_Term>();
            Student_Major_Class = new HashSet<Student_Major_Class>();
        }

        [Key]
        [StringLength(6)]
        public string Major_class_Id { get; set; }

        [StringLength(100)]
        public string Major_class_Name { get; set; }

        public int? Major_class_Startedyear { get; set; }

        public int? Major_class_Numberofstudents { get; set; }

        [StringLength(10)]
        public string Training_programme_course_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lecturer_majorclass> Lecturer_majorclass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Major_Class_Term> Major_Class_Term { get; set; }

        public virtual TRAINING_PROGRAMME_COURSE TRAINING_PROGRAMME_COURSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Major_Class> Student_Major_Class { get; set; }
    }
}
