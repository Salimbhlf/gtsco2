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
            Contract_avenant_changement = new HashSet<Contract_avenant_changement>();
            Contrat_changement_employeur = new HashSet<Contrat_changement_employeur>();
            Decisions = new HashSet<Decision>();
            Evaluations = new HashSet<Evaluation>();
            soiver_stg = new HashSet<soiver_stg>();
            Transferers = new HashSet<Transferer>();
        }

        [Key]
        [StringLength(12)]
        public string Num_STG { get; set; }

        [StringLength(25)]
        public string Nom { get; set; }

        [StringLength(25)]
        public string Prenom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_de_Naissance { get; set; }

        [StringLength(40)]
        public string Lieu_Naissance { get; set; }

        [StringLength(80)]
        public string Adresse { get; set; }

        public int? Code_postal { get; set; }

        [StringLength(50)]
        public string Commune { get; set; }

        [StringLength(5)]
        public string Sexe { get; set; }

        public int? Telephone { get; set; }

        [Column("E-Maile")]
        [StringLength(30)]
        public string E_Maile { get; set; }

        [StringLength(25)]
        public string Nivo_SCO { get; set; }

        [StringLength(25)]
        public string Prenom_Père_STG { get; set; }

        [StringLength(25)]
        public string Nom_Mère_STG { get; set; }

        [StringLength(25)]
        public string Prenom_Mère_STG { get; set; }

        public int? Nbr_Frère_STG { get; set; }

        [StringLength(20)]
        public string Situation_Familiale_STG { get; set; }

        [StringLength(20)]
        public string Situation_Familiale_Parents_STG { get; set; }

        [StringLength(25)]
        public string Profession_Père_STG { get; set; }

        [StringLength(25)]
        public string Profession_Mère_STG { get; set; }

        [StringLength(25)]
        public string Nationalité_STG { get; set; }

        [StringLength(20)]
        public string Num_Diplom_STG { get; set; }

        public int? ID_Emp { get; set; }

        public int? Num_Validation_Contrat_STG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Validation_Contrat_STG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Resiliation_Contrat_STG { get; set; }

        public int? ID_Maitre_Apprentissage { get; set; }

        public int? ID_ETAB { get; set; }

        public int? Num_Avenant_Cont_Prorogation { get; set; }

        public int? Num_Validation_Cont_Prorogation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_D_Prorgation { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_F_Prorogation { get; set; }

        public int? Section { get; set; }

        public int? id_tuteur { get; set; }

        public int? ID_Promo { get; set; }

        [Column(TypeName = "image")]
        public byte[] photo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Absence> Absences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract_avenant_changement> Contract_avenant_changement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrat_changement_employeur> Contrat_changement_employeur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Decision> Decisions { get; set; }

        public virtual Employeur Employeur { get; set; }

        public virtual Etablissement Etablissement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluation> Evaluations { get; set; }

        public virtual Maitre_Apprentissage Maitre_Apprentissage { get; set; }

        public virtual Promo Promo { get; set; }

        public virtual Section Section1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<soiver_stg> soiver_stg { get; set; }

        public virtual tuteur tuteur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transferer> Transferers { get; set; }
    }
}
