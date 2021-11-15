namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lecturer_majorclass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lecturer_majorclass()
        {
            LEADERSHIP_PROCESS = new HashSet<LEADERSHIP_PROCESS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Lecturer_majorclass_Id { get; set; }

        [StringLength(6)]
        public string Major_class_Id { get; set; }

        [StringLength(10)]
        public string Lecturer_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LEADERSHIP_PROCESS> LEADERSHIP_PROCESS { get; set; }

        public virtual LECTURER LECTURER { get; set; }

        public virtual MAJOR_CLASS MAJOR_CLASS { get; set; }
    }
}
