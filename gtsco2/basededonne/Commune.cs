namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Commune")]
    public partial class Commune
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commune()
        {
            Code_Postal = new HashSet<Code_Postal>();
            Maitre_Apprentissage = new HashSet<Maitre_Apprentissage>();
            Stagiairs = new HashSet<Stagiair>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Commune_id { get; set; }

        [StringLength(50)]
        public string Commune_name { get; set; }

        [StringLength(50)]
        public string Commune_name_ar { get; set; }

        [StringLength(50)]
        public string Daira_name { get; set; }

        [StringLength(50)]
        public string Daira_name_ar { get; set; }

        public int? Code_Willaya { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Code_Postal> Code_Postal { get; set; }

        public virtual Willaya Willaya { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maitre_Apprentissage> Maitre_Apprentissage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stagiair> Stagiairs { get; set; }
    }
}
