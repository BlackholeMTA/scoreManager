namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCHOLARSHIP")]
    public partial class SCHOLARSHIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCHOLARSHIP()
        {
            Student_Scholarship_Major = new HashSet<Student_Scholarship_Major>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Scholarship_Id { get; set; }

        [StringLength(100)]
        public string Scholarship_Name { get; set; }

        public int? Scholarship_Value { get; set; }

        [StringLength(6)]
        public string Scholarship_Currency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Scholarship_Major> Student_Scholarship_Major { get; set; }
    }
}
