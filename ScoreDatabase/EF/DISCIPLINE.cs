namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DISCIPLINE")]
    public partial class DISCIPLINE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DISCIPLINE()
        {
            Student_Discipline = new HashSet<Student_Discipline>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Discipline_Id { get; set; }

        [StringLength(6)]
        public string Discipline_Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Discipline_Description { get; set; }

        public int? Discipline_length { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Discipline> Student_Discipline { get; set; }
    }
}
