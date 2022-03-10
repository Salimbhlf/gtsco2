namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mode_formation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mode_formation()
        {
            Enseignants = new HashSet<Enseignant>();
            Promoes = new HashSet<Promo>();
            Sections = new HashSet<Section>();
        }

        [Key]
        public int ID_Mode_Formation { get; set; }

        [StringLength(10)]
        public string Code_Mode_Formation { get; set; }

        [StringLength(30)]
        public string Désignation_Mode_Formation { get; set; }

        [StringLength(30)]
        public string Désignation_Mode_Formation_ar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enseignant> Enseignants { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promo> Promoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Section> Sections { get; set; }
    }
}
