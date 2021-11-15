namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Major_Class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student_Major_Class()
        {
            Student_Class = new HashSet<Student_Class>();
            Student_Competition_Prize = new HashSet<Student_Competition_Prize>();
            Student_Course_Optionalsub = new HashSet<Student_Course_Optionalsub>();
            Student_E_Sub = new HashSet<Student_E_Sub>();
            Student_Scholarship_Major = new HashSet<Student_Scholarship_Major>();
            Student_Subject_Major_Class = new HashSet<Student_Subject_Major_Class>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Student_Major_Class_Id { get; set; }

        [StringLength(8)]
        public string Student_Id { get; set; }

        [StringLength(6)]
        public string Major_class_Id { get; set; }

        [StringLength(50)]
        public string Student_Major_Class_Admission { get; set; }

        public decimal? Student_Major_Class_CPA { get; set; }

        public int? Student_Major_Class_numofcredits { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Student_Major_Class_Begin { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Student_Major_Class_End { get; set; }

        public int? Student_Major_Class_Status { get; set; }

        public int? Student_Major_Class_assignedcredits { get; set; }

        [StringLength(2)]
        public string Student_Major_Class_Test { get; set; }

        public double? Student_Major_Class_Sum_E_Sub { get; set; }

        [StringLength(10)]
        public string Training_programme_course_Id { get; set; }

        public decimal? TongTichLuy { get; set; }

        public decimal? TongTichLuy10 { get; set; }

        public decimal? DiemTB10 { get; set; }

        public decimal? Bonus_Point { get; set; }

        public virtual MAJOR_CLASS MAJOR_CLASS { get; set; }

        public virtual STUDENT STUDENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Class> Student_Class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Competition_Prize> Student_Competition_Prize { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Course_Optionalsub> Student_Course_Optionalsub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_E_Sub> Student_E_Sub { get; set; }

        public virtual TRAINING_PROGRAMME_COURSE TRAINING_PROGRAMME_COURSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Scholarship_Major> Student_Scholarship_Major { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Subject_Major_Class> Student_Subject_Major_Class { get; set; }
    }
}
