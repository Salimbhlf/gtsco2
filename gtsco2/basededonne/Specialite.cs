namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Specialite")]
    public partial class Specialite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specialite()
        {
            Options = new HashSet<Option>();
        }

        [Key]
        public int ID_Specialité { get; set; }

        [StringLength(10)]
        public string Code_SP { get; set; }

        [StringLength(500)]
        public string Designation_SP { get; set; }

        [StringLength(500)]
        public string Designation_SP_AR { get; set; }

        public int? Niveau_qualification { get; set; }

        [StringLength(15)]
        public string ID_Branche { get; set; }

        public virtual Branch Branch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Option> Options { get; set; }
    }
}
