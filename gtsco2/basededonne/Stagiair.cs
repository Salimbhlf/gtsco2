namespace gtsco2.basededonne
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stagiair")]
    public partial class Stagiair
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stagiair()
        {
            Absences = new HashSet<Absence>();
            Avenant_contrat_prorogation = new HashSet<Avenant_contrat_prorogation>();
            Contract_avenant_changement = new HashSet<Contract_avenant_changement>();
            Decisions = new HashSet<Decision>();
            Evaluations = new HashSet<Evaluation>();
            Suiver_stagiaire = new HashSet<Suiver_stagiaire>();
            Transferers = new HashSet<Transferer>();
        }

        [Key]
        [StringLength(12)]
        public string Num_STG { get; set; }

        
        public string Nom { get; set; }

        [StringLength(100)]
        public string Nom_ar { get; set; }

        [StringLength(100)]
        public string Prenom { get; set; }

        [StringLength(100)]
        public string Prenom_ar { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_de_Naissance { get; set; }

        public int? Lieu_Naissance { get; set; }

        
        public string Adresse { get; set; }

        [StringLength(500)]
        public string Adresse_ar { get; set; }

        public int? Code_postal { get; set; }

        [StringLength(10)]
        public string Sexe { get; set; }

        public bool? Etranger { get; set; }

        [StringLength(25)]
        public string Nationalité_STG { get; set; }

        public bool? Handicape { get; set; }

        [StringLength(100)]
        public string Observation_handicape { get; set; }

        public string Telephone { get; set; }

        [Column("E-Maile")]
        
        public string E_Maile { get; set; }

        
        public string Nivo_SCO { get; set; }

        
        public string Nivo_SCO_ar { get; set; }

        [StringLength(50)]
        public string Prenom_Père_STG { get; set; }

        [StringLength(50)]
        public string Prenom_Père_STG_ar { get; set; }

        [StringLength(50)]
        public string Nom_Mère_STG { get; set; }

        [StringLength(25)]
        public string Nom_Mère_STG_ar { get; set; }

        [StringLength(25)]
        public string Prenom_Mère_STG { get; set; }

        [StringLength(25)]
        public string Prenom_Mère_STG_ar { get; set; }

        public int? Nbr_Frère_STG { get; set; }

        [StringLength(20)]
        public string Situation_Familiale_STG { get; set; }

        [StringLength(20)]
        public string Situation_Familiale_Parents_STG { get; set; }

        [StringLength(25)]
        public string Profession_Père_STG { get; set; }

        [StringLength(25)]
        public string Profession_Mère_STG { get; set; }

        [StringLength(20)]
        public string Num_Diplome_STG { get; set; }

        public int? ID_Emp { get; set; }

        public int? Num_Validation_Contrat_STG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Validation_Contrat_STG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Resiliation_Contrat_STG { get; set; }

        public int? ID_Maitre_Apprentissage { get; set; }

        public int? ID_ETAB { get; set; }

        public int? Section { get; set; }

        public int? id_tuteur { get; set; }

        public int? ID_Promo { get; set; }

        [Column(TypeName = "image")]
        public byte[] photo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Absence> Absences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avenant_contrat_prorogation> Avenant_contrat_prorogation { get; set; }

        public virtual Code_Postal Code_Postal1 { get; set; }

        public virtual Commune Commune { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract_avenant_changement> Contract_avenant_changement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Decision> Decisions { get; set; }

        public virtual Employeur Employeur { get; set; }

        public virtual Etablissement Etablissement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluation> Evaluations { get; set; }

        public virtual Maitre_Apprentissage Maitre_Apprentissage { get; set; }

        public virtual Promo Promo { get; set; }

        public virtual Section Section1 { get; set; }

        public virtual tuteur tuteur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suiver_stagiaire> Suiver_stagiaire { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transferer> Transferers { get; set; }
    }
}
