namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employeur")]
    public partial class Employeur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employeur()
        {
            Contract_avenant_changement = new HashSet<Contract_avenant_changement>();
            Contrat_changement_employeur = new HashSet<Contrat_changement_employeur>();
            Maitre_Apprentissage = new HashSet<Maitre_Apprentissage>();
            Stagiairs = new HashSet<Stagiair>();
        }

        [Key]
        public int ID_Emp { get; set; }

        [StringLength(10)]
        public string Type_Emp { get; set; }

        [StringLength(6)]
        public string Nature_Emp { get; set; }

        [StringLength(25)]
        public string Nom_Emp { get; set; }

        [StringLength(25)]
        public string Statut_Emp { get; set; }

        [StringLength(80)]
        public string Adresse_Emp { get; set; }

        public int? Code_Postal_Emp { get; set; }

        [StringLength(50)]
        public string Commune_Emp { get; set; }

        public int? Tel_Emp { get; set; }

        public int? Fax_Emp { get; set; }

        [StringLength(30)]
        public string Mail_Emp { get; set; }

        [StringLength(30)]
        public string Fonction_Emp { get; set; }

        [StringLength(50)]
        public string Secteur_Activité_Emp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract_avenant_changement> Contract_avenant_changement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrat_changement_employeur> Contrat_changement_employeur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maitre_Apprentissage> Maitre_Apprentissage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stagiair> Stagiairs { get; set; }
    }
}
