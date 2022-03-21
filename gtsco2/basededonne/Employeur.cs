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
            Avenant_contrat_prorogation = new HashSet<Avenant_contrat_prorogation>();
            Contract_avenant_changement = new HashSet<Contract_avenant_changement>();
            Maitre_Apprentissage = new HashSet<Maitre_Apprentissage>();
            Stagiairs = new HashSet<Stagiair>();
        }

        [Key]
        public int ID_Emp { get; set; }

        [StringLength(10)]
        public string Type_Emp { get; set; }

        [StringLength(6)]
        public string Nature_Emp { get; set; }

        [StringLength(80)]
        public string Nom_Emp { get; set; }

        [StringLength(80)]
        public string Nom_Emp_ar { get; set; }

        [StringLength(25)]
        public string Statut_Emp { get; set; }

        [StringLength(80)]
        public string Adresse_Emp { get; set; }

        [StringLength(80)]
        public string Adresse_Emp_ar { get; set; }

        public int? Code_Postal_Emp { get; set; }

        public int? Tel_Emp { get; set; }

        public int? Fax_Emp { get; set; }

        [StringLength(30)]
        public string Mail_Emp { get; set; }

        [StringLength(30)]
        public string Fonction_Emp { get; set; }

        [StringLength(50)]
        public string Secteur_Activité_Emp { get; set; }

        public int? Effectif_Trv { get; set; }

        public int? Effectif_apt { get; set; }

        public int? Quota_max { get; set; }

        public int? Qouta_MIN { get; set; }

        public bool? Existance_une_structure_de_formation { get; set; }

        [StringLength(150)]
        public string Nom_et_prenom_et_fonction_de_responsble_de_la_steucture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avenant_contrat_prorogation> Avenant_contrat_prorogation { get; set; }

        public virtual Code_Postal Code_Postal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract_avenant_changement> Contract_avenant_changement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maitre_Apprentissage> Maitre_Apprentissage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stagiair> Stagiairs { get; set; }
    }
}
