namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRAINING_PROGRAMME_COURSE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRAINING_PROGRAMME_COURSE()
        {
            Course_Group_E_Sub = new HashSet<Course_Group_E_Sub>();
            GROUP_SUBJECTS = new HashSet<GROUP_SUBJECTS>();
            MAJOR_CLASS = new HashSet<MAJOR_CLASS>();
            Student_Major_Class = new HashSet<Student_Major_Class>();
        }

        [Key]
        [StringLength(10)]
        public string Training_programme_course_Id { get; set; }

        public int? TPC_Year { get; set; }

        public int? TPC_Numberofcredits { get; set; }

        public int? TPC_Requiednumofcredits { get; set; }

        public int? TPC_course { get; set; }

        [StringLength(8)]
        public string Training_programme_Id { get; set; }

        public int? TPC_Required_Optional_Cre { get; set; }

        public decimal? TCP_length { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Group_E_Sub> Course_Group_E_Sub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GROUP_SUBJECTS> GROUP_SUBJECTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAJOR_CLASS> MAJOR_CLASS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Major_Class> Student_Major_Class { get; set; }

        public virtual TRAINING_PROGRAMME TRAINING_PROGRAMME { get; set; }
    }
}
