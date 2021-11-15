namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lecturer_Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lecturer_Department()
        {
            WORKING_PROCESS = new HashSet<WORKING_PROCESS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Lecturer_Department_Id { get; set; }

        [StringLength(10)]
        public string Lecturer_Id { get; set; }

        [StringLength(6)]
        public string Department_Id { get; set; }

        public virtual DEPARTMENT DEPARTMENT { get; set; }

        public virtual LECTURER LECTURER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WORKING_PROCESS> WORKING_PROCESS { get; set; }
    }
}
