namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Promo")]
    public partial class Promo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Promo()
        {
            Decisions = new HashSet<Decision>();
            Sections = new HashSet<Section>();
            Stagiairs = new HashSet<Stagiair>();
        }

        [Key]
        public int ID_Promo { get; set; }

        [StringLength(10)]
        public string Code_Promo { get; set; }

        [StringLength(30)]
        public string Diplome { get; set; }

        [StringLength(50)]
        public string Diplome_ar { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_D_Formation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_F_Formation { get; set; }

        public int? ID_Option { get; set; }

        public int? Mode_de_formation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Decision> Decisions { get; set; }

        public virtual Mode_formation Mode_formation { get; set; }

        public virtual Option Option { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Section> Sections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stagiair> Stagiairs { get; set; }
    }
}
