namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GROUP_SUBJECTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GROUP_SUBJECTS()
        {
            Subject_Subjectgroup = new HashSet<Subject_Subjectgroup>();
        }

        [Key]
        [StringLength(6)]
        public string Group_Subject_Id { get; set; }

        [StringLength(100)]
        public string Group_Subject_Name { get; set; }

        public int? Group_Subject_Number { get; set; }

        public int? Group_Subject_Numbercredits { get; set; }

        [StringLength(10)]
        public string Training_programme_course_Id { get; set; }

        public int? Requiredcredits { get; set; }

        public virtual TRAINING_PROGRAMME_COURSE TRAINING_PROGRAMME_COURSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subject_Subjectgroup> Subject_Subjectgroup { get; set; }
    }
}
