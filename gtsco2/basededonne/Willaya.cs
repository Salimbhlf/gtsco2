namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Willaya")]
    public partial class Willaya
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Willaya()
        {
            Communes = new HashSet<Commune>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Wilaya_Code { get; set; }

        [Column("Wilaya_name _ar")]
        [StringLength(50)]
        public string Wilaya_name__ar { get; set; }

        [Column("Wilaya_name _fr]")]
        [StringLength(50)]
        public string Wilaya_name__fr_ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commune> Communes { get; set; }
    }
}
