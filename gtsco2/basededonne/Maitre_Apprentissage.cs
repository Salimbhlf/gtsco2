namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Maitre_Apprentissage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maitre_Apprentissage()
        {
            Stagiairs = new HashSet<Stagiair>();
        }

        [Key]
        public int ID_Maitre_Apprentissage { get; set; }

        public int? ID_Emp { get; set; }

        [StringLength(25)]
        public string Nom_Maitre_Apprentissage { get; set; }

        [StringLength(25)]
        public string Prenom_Maitre_Apprentissage { get; set; }

        [StringLength(50)]
        public string Qualification_Maitre_Apprentissage { get; set; }

        [StringLength(30)]
        public string Profil_Maitre_Apprentissage { get; set; }

        [StringLength(30)]
        public string Poste_Maitre_Apprentissage { get; set; }

        public int? Ancienté_Métier_Maitre_Apprentissage { get; set; }

        public int? Ancienté_Entriprise_Maitre_Apprentissage { get; set; }

        [StringLength(3)]
        public string Ayant_Suivie_Stage { get; set; }

        public int? Nbr_Stgiaire_Former { get; set; }

        [StringLength(80)]
        public string Adresse_Maitre_Apprentissage { get; set; }

        [StringLength(40)]
        public string Commune_Maitre_Apprentissage { get; set; }

        [StringLength(40)]
        public string Daira_Maitre_Apprentissage { get; set; }

        [StringLength(30)]
        public string Wilaya_Maitre_Apprentissage { get; set; }

        [StringLength(30)]
        public string Mail_Maitre_Apprentissage { get; set; }

        public int? Tel_Maitre_Apprentissage { get; set; }

        public virtual Employeur Employeur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stagiair> Stagiairs { get; set; }
    }
}
