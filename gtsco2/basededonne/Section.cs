namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Section")]
    public partial class Section
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Section()
        {
            Stagiairs = new HashSet<Stagiair>();
        }

        public int SectionID { get; set; }

        [StringLength(10)]
        public string Code_Section { get; set; }

        public int? ID_Promo { get; set; }

        public int? ID_Mode_Formation { get; set; }

        public int? ID_Option { get; set; }

        public int? Semestre_en_coure { get; set; }

        public int? Annee_secolir_en_coure { get; set; }

        public virtual annee_scolaire annee_scolaire { get; set; }

        public virtual Mode_formation Mode_formation { get; set; }

        public virtual Option Option { get; set; }

        public virtual Promo Promo { get; set; }

        public virtual Semestre Semestre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stagiair> Stagiairs { get; set; }
    }
}
