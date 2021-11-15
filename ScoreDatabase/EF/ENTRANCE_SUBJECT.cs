namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENTRANCE_SUBJECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ENTRANCE_SUBJECT()
        {
            Group_E_Sub_E_Sub = new HashSet<Group_E_Sub_E_Sub>();
            Student_E_Sub = new HashSet<Student_E_Sub>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Entrance_Subject_Id { get; set; }

        [StringLength(25)]
        public string Entrance_Subject_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group_E_Sub_E_Sub> Group_E_Sub_E_Sub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_E_Sub> Student_E_Sub { get; set; }
    }
}
