using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace gtsco2.basededonne
{
    public partial class gtsco : DbContext
    {
        public gtsco()
            : base("name=gtsco")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Absence> Absences { get; set; }
        public virtual DbSet<annee_scolaire> annee_scolaire { get; set; }
        public virtual DbSet<Avenant_contrat_prorogation> Avenant_contrat_prorogation { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Code_Postal> Code_Postal { get; set; }
        public virtual DbSet<Commune> Communes { get; set; }
        public virtual DbSet<Contract_avenant_changement> Contract_avenant_changement { get; set; }
        public virtual DbSet<Decision> Decisions { get; set; }
        public virtual DbSet<Employeur> Employeurs { get; set; }
        public virtual DbSet<Enseignant> Enseignants { get; set; }
        public virtual DbSet<Etablissement> Etablissements { get; set; }
        public virtual DbSet<Evaluation> Evaluations { get; set; }
        public virtual DbSet<Maitre_Apprentissage> Maitre_Apprentissage { get; set; }
        public virtual DbSet<Mode_formation> Mode_formation { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Proce_verbal_delibation> Proce_verbal_delibation { get; set; }
        public virtual DbSet<Promo> Promoes { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Semestre> Semestres { get; set; }
        public virtual DbSet<Specialite> Specialites { get; set; }
        public virtual DbSet<Stagiair> Stagiairs { get; set; }
        public virtual DbSet<Suiver_stagiaire> Suiver_stagiaire { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Transferer> Transferers { get; set; }
        public virtual DbSet<tuteur> tuteurs { get; set; }
        public virtual DbSet<Willaya> Willayas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Absence>()
                .Property(e => e.Justif_ABS)
                .IsUnicode(false);

            modelBuilder.Entity<Absence>()
                .Property(e => e.Num_STG)
                .IsUnicode(false);

            modelBuilder.Entity<annee_scolaire>()
                .Property(e => e.Designation)
                .IsUnicode(false);

            modelBuilder.Entity<annee_scolaire>()
                .Property(e => e.Session_Année_SCO)
                .IsUnicode(false);

            modelBuilder.Entity<annee_scolaire>()
                .HasMany(e => e.Evaluations)
                .WithRequired(e => e.annee_scolaire)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Avenant_contrat_prorogation>()
                .Property(e => e.Num_stg)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Code_Branche)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .Property(e => e.Designation_Branche)
                .IsUnicode(false);

            modelBuilder.Entity<Branch>()
                .HasMany(e => e.Specialites)
                .WithOptional(e => e.Branch)
                .HasForeignKey(e => e.ID_Branche);

            modelBuilder.Entity<Code_Postal>()
                .Property(e => e.Post_adresse)
                .IsUnicode(false);

            modelBuilder.Entity<Code_Postal>()
                .HasMany(e => e.Employeurs)
                .WithOptional(e => e.Code_Postal)
                .HasForeignKey(e => e.Code_Postal_Emp);

            modelBuilder.Entity<Code_Postal>()
                .HasMany(e => e.Etablissements)
                .WithOptional(e => e.Code_Postal)
                .HasForeignKey(e => e.Code_Postal_EATB);

            modelBuilder.Entity<Code_Postal>()
                .HasMany(e => e.Stagiairs)
                .WithOptional(e => e.Code_Postal1)
                .HasForeignKey(e => e.Code_postal);

            modelBuilder.Entity<Commune>()
                .Property(e => e.Commune_name)
                .IsUnicode(false);

            modelBuilder.Entity<Commune>()
                .Property(e => e.Daira_name)
                .IsUnicode(false);

            modelBuilder.Entity<Commune>()
                .HasMany(e => e.Maitre_Apprentissage)
                .WithOptional(e => e.Commune)
                .HasForeignKey(e => e.Commune_Maitre_Apprentissage);

            modelBuilder.Entity<Commune>()
                .HasMany(e => e.Stagiairs)
                .WithOptional(e => e.Commune)
                .HasForeignKey(e => e.Lieu_Naissance);

            modelBuilder.Entity<Contract_avenant_changement>()
                .Property(e => e.num_stg)
                .IsUnicode(false);

            modelBuilder.Entity<Decision>()
                .Property(e => e.Type_Decision)
                .IsUnicode(false);

            modelBuilder.Entity<Decision>()
                .Property(e => e.Num_STG)
                .IsUnicode(false);

            modelBuilder.Entity<Employeur>()
                .Property(e => e.Type_Emp)
                .IsUnicode(false);

            modelBuilder.Entity<Employeur>()
                .Property(e => e.Nature_Emp)
                .IsUnicode(false);

            modelBuilder.Entity<Employeur>()
                .Property(e => e.Nom_Emp)
                .IsUnicode(false);

            modelBuilder.Entity<Employeur>()
                .Property(e => e.Nom_Emp_ar)
                .IsUnicode(false);

            modelBuilder.Entity<Employeur>()
                .Property(e => e.Statut_Emp)
                .IsUnicode(false);

            modelBuilder.Entity<Employeur>()
                .Property(e => e.Adresse_Emp)
                .IsUnicode(false);

            modelBuilder.Entity<Employeur>()
                .Property(e => e.Mail_Emp)
                .IsUnicode(false);

            modelBuilder.Entity<Employeur>()
                .Property(e => e.Fonction_Emp)
                .IsUnicode(false);

            modelBuilder.Entity<Employeur>()
                .Property(e => e.Secteur_Activité_Emp)
                .IsUnicode(false);

            modelBuilder.Entity<Employeur>()
                .HasMany(e => e.Avenant_contrat_prorogation)
                .WithRequired(e => e.Employeur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employeur>()
                .HasMany(e => e.Contract_avenant_changement)
                .WithRequired(e => e.Employeur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Enseignant>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<Enseignant>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<Enseignant>()
                .Property(e => e.Specialite)
                .IsUnicode(false);

            modelBuilder.Entity<Enseignant>()
                .HasMany(e => e.Evaluations)
                .WithOptional(e => e.Enseignant1)
                .HasForeignKey(e => e.Enseignant);

            modelBuilder.Entity<Enseignant>()
                .HasMany(e => e.Suiver_stagiaire)
                .WithRequired(e => e.Enseignant1)
                .HasForeignKey(e => e.Enseignant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Etablissement>()
                .Property(e => e.Nom_ETAB)
                .IsUnicode(false);

            modelBuilder.Entity<Etablissement>()
                .Property(e => e.Mail_ETAB)
                .IsUnicode(false);

            modelBuilder.Entity<Etablissement>()
                .Property(e => e.Adresse_ETAB)
                .IsUnicode(false);

            modelBuilder.Entity<Etablissement>()
                .HasMany(e => e.Transferers)
                .WithRequired(e => e.Etablissement)
                .HasForeignKey(e => e.ID_etb)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Evaluation>()
                .Property(e => e.Num_STG)
                .IsUnicode(false);

            modelBuilder.Entity<Maitre_Apprentissage>()
                .Property(e => e.Nom_Maitre_Apprentissage)
                .IsUnicode(false);

            modelBuilder.Entity<Maitre_Apprentissage>()
                .Property(e => e.Prenom_Maitre_Apprentissage)
                .IsUnicode(false);

            modelBuilder.Entity<Maitre_Apprentissage>()
                .Property(e => e.Qualification_Maitre_Apprentissage)
                .IsUnicode(false);

            modelBuilder.Entity<Maitre_Apprentissage>()
                .Property(e => e.Profil_Maitre_Apprentissage)
                .IsUnicode(false);

            modelBuilder.Entity<Maitre_Apprentissage>()
                .Property(e => e.Poste_Maitre_Apprentissage)
                .IsUnicode(false);

            modelBuilder.Entity<Maitre_Apprentissage>()
                .Property(e => e.Ayant_Suivie_Stage)
                .IsUnicode(false);

            modelBuilder.Entity<Maitre_Apprentissage>()
                .Property(e => e.Adresse_Maitre_Apprentissage)
                .IsUnicode(false);

            modelBuilder.Entity<Maitre_Apprentissage>()
                .Property(e => e.E_Mail_Maitre_Apprentissage)
                .IsUnicode(false);

            modelBuilder.Entity<Mode_formation>()
                .Property(e => e.Code_Mode_Formation)
                .IsUnicode(false);

            modelBuilder.Entity<Mode_formation>()
                .Property(e => e.Désignation_Mode_Formation)
                .IsUnicode(false);

            modelBuilder.Entity<Mode_formation>()
                .HasMany(e => e.Enseignants)
                .WithOptional(e => e.Mode_formation1)
                .HasForeignKey(e => e.Mode_Formation);

            modelBuilder.Entity<Mode_formation>()
                .HasMany(e => e.Promoes)
                .WithOptional(e => e.Mode_formation)
                .HasForeignKey(e => e.Mode_de_formation);

            modelBuilder.Entity<Module>()
                .Property(e => e.Designation_Module)
                .IsUnicode(false);

            modelBuilder.Entity<Module>()
                .HasMany(e => e.Evaluations)
                .WithRequired(e => e.Module)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Option>()
                .Property(e => e.Code_Option)
                .IsUnicode(false);

            modelBuilder.Entity<Option>()
                .Property(e => e.Designation_Option)
                .IsUnicode(false);

            modelBuilder.Entity<Promo>()
                .Property(e => e.Code_Promo)
                .IsUnicode(false);

            modelBuilder.Entity<Promo>()
                .Property(e => e.Diplome)
                .IsUnicode(false);

            modelBuilder.Entity<Section>()
                .Property(e => e.Code_Section)
                .IsUnicode(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Stagiairs)
                .WithOptional(e => e.Section1)
                .HasForeignKey(e => e.Section);

            modelBuilder.Entity<Semestre>()
                .Property(e => e.Designation_Semestre)
                .IsUnicode(false);

            modelBuilder.Entity<Semestre>()
                .HasMany(e => e.Evaluations)
                .WithRequired(e => e.Semestre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Semestre>()
                .HasMany(e => e.Suiver_stagiaire)
                .WithRequired(e => e.Semestre1)
                .HasForeignKey(e => e.semestre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specialite>()
                .Property(e => e.Code_SP)
                .IsUnicode(false);

            modelBuilder.Entity<Specialite>()
                .Property(e => e.Designation_SP)
                .IsUnicode(false);

            modelBuilder.Entity<Specialite>()
                .Property(e => e.ID_Branche)
                .IsUnicode(false);

            modelBuilder.Entity<Specialite>()
                .HasMany(e => e.Options)
                .WithOptional(e => e.Specialite1)
                .HasForeignKey(e => e.Specialite);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Num_STG)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Prenom)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Adresse)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Sexe)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Nationalité_STG)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Observation_handicape)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.E_Maile)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Nivo_SCO)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Prenom_Père_STG)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Nom_Mère_STG)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Prenom_Mère_STG)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Situation_Familiale_STG)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Situation_Familiale_Parents_STG)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Profession_Père_STG)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Profession_Mère_STG)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .Property(e => e.Num_Diplome_STG)
                .IsUnicode(false);

            modelBuilder.Entity<Stagiair>()
                .HasMany(e => e.Avenant_contrat_prorogation)
                .WithRequired(e => e.Stagiair)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stagiair>()
                .HasMany(e => e.Contract_avenant_changement)
                .WithRequired(e => e.Stagiair)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stagiair>()
                .HasMany(e => e.Evaluations)
                .WithRequired(e => e.Stagiair)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stagiair>()
                .HasMany(e => e.Suiver_stagiaire)
                .WithRequired(e => e.Stagiair)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stagiair>()
                .HasMany(e => e.Transferers)
                .WithRequired(e => e.Stagiair)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Suiver_stagiaire>()
                .Property(e => e.num_stg)
                .IsUnicode(false);

            modelBuilder.Entity<Suiver_stagiaire>()
                .Property(e => e.OBSERV_FORMAT)
                .IsUnicode(false);

            modelBuilder.Entity<Transferer>()
                .Property(e => e.num_stg)
                .IsUnicode(false);

            modelBuilder.Entity<Transferer>()
                .Property(e => e.nom_directeur)
                .IsUnicode(false);

            modelBuilder.Entity<Transferer>()
                .Property(e => e.prenom_directeur)
                .IsUnicode(false);

            modelBuilder.Entity<tuteur>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<tuteur>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<tuteur>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<tuteur>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Willaya>()
                .Property(e => e.Wilaya_name__fr_)
                .IsUnicode(false);

            modelBuilder.Entity<Willaya>()
                .HasMany(e => e.Communes)
                .WithOptional(e => e.Willaya)
                .HasForeignKey(e => e.Code_Willaya);
        }
    }
}
