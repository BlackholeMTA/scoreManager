namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLASS")]
    public partial class CLASS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLASS()
        {
            Student_Class = new HashSet<Student_Class>();
        }

        [Key]
        [StringLength(8)]
        public string Class_Id { get; set; }

        [StringLength(10)]
        public string Lecturer_Id { get; set; }

        [StringLength(5)]
        public string Term_Id { get; set; }

        [StringLength(8)]
        public string Subject_Id { get; set; }

        [StringLength(50)]
        public string Class_Address { get; set; }

        [StringLength(50)]
        public string Class_Password { get; set; }

        public int? Class_NumberofStudent { get; set; }

        public int? Class_MaxnumberofStudent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Class> Student_Class { get; set; }

        public virtual LECTURER LECTURER { get; set; }

        public virtual TERM TERM { get; set; }

        public virtual SUBJECT SUBJECT { get; set; }
    }
}
