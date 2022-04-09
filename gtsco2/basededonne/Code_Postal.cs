namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Code_Postal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Code_Postal()
        {
            Employeurs = new HashSet<Employeur>();
            Etablissements = new HashSet<Etablissement>();
            Stagiairs = new HashSet<Stagiair>();
            tuteurs = new HashSet<tuteur>();
        }

        [Key]
        public int ID_Code_Postal { get; set; }

        [Column("Code_Postal")]
        public string Code_Postal1 { get; set; }

        [StringLength(50)]
        public string post_Adresse_ar { get; set; }

        [StringLength(50)]
        public string Post_adresse { get; set; }

        public int? Commune_id { get; set; }

        public virtual Commune Commune { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employeur> Employeurs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Etablissement> Etablissements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stagiair> Stagiairs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tuteur> tuteurs { get; set; }
    }
}
