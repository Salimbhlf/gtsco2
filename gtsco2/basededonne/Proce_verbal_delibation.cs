namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proce_verbal_delibation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proce_verbal_delibation()
        {
            Decisions = new HashSet<Decision>();
        }

        [Key]
        public int ID_PV_Délibiration { get; set; }

        public int? Num_PV_Délibiraiton { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_PV_Délibiration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Decision> Decisions { get; set; }
    }
}
