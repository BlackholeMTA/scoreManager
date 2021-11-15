namespace ScoreDatabase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GROUP_E_SUBJECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GROUP_E_SUBJECT()
        {
            Course_Group_E_Sub = new HashSet<Course_Group_E_Sub>();
            Group_E_Sub_E_Sub = new HashSet<Group_E_Sub_E_Sub>();
        }

        [Key]
        [StringLength(10)]
        public string Group_E_Subject_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Group_E_Sub> Course_Group_E_Sub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group_E_Sub_E_Sub> Group_E_Sub_E_Sub { get; set; }
    }
}
