namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prof")]
    public partial class prof
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public prof()
        {
            soiver_stg = new HashSet<soiver_stg>();
        }

        [Key]
        public int id_prof { get; set; }

        [StringLength(50)]
        public string nom { get; set; }

        [StringLength(50)]
        public string prenom { get; set; }

        [StringLength(50)]
        public string spesalite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<soiver_stg> soiver_stg { get; set; }
    }
}
