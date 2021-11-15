namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPETITION_PRIZE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPETITION_PRIZE()
        {
            Student_Competition_Prize = new HashSet<Student_Competition_Prize>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Competition_Prize_Id { get; set; }

        [StringLength(100)]
        public string Competition_Prize_Name { get; set; }

        public decimal? Competition_Prize_Bonus_Point { get; set; }

        public int? Competition_Id { get; set; }

        public virtual COMPETITION COMPETITION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Competition_Prize> Student_Competition_Prize { get; set; }
    }
}
