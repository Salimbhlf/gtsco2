namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Etablissement")]
    public partial class Etablissement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Etablissement()
        {
            Stagiairs = new HashSet<Stagiair>();
            Transferers = new HashSet<Transferer>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ETAB { get; set; }

        [StringLength(25)]
        public string Nom_ETAB { get; set; }

        public int? Tél_ETAB { get; set; }

        public int? Fax_ETAB { get; set; }

        [StringLength(30)]
        public string Mail_ETAB { get; set; }

        public int? Code_Postal_EATB { get; set; }

        [StringLength(40)]
        public string Commune_ETAB { get; set; }

        [StringLength(80)]
        public string Adresse_ETAB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stagiair> Stagiairs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transferer> Transferers { get; set; }
    }
}
