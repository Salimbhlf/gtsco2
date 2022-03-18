using DevExpress.Mvvm.DataModel;
using gtsco2.basededonne;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gtsco2.mvvm.gtscoDataModel {

    /// <summary>
    /// IgtscoUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IgtscoUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Absence entities repository.
        /// </summary>
		IRepository<Absence, int> Absences { get; }
        
        /// <summary>
        /// The annee_scolaire entities repository.
        /// </summary>
		IRepository<annee_scolaire, int> annee_scolaire { get; }
        
        /// <summary>
        /// The Evaluation entities repository.
        /// </summary>
		IRepository<Evaluation, Tuple<string, int, int, int>> Evaluations { get; }
        
        /// <summary>
        /// The Enseignant entities repository.
        /// </summary>
		IRepository<Enseignant, int> Enseignants { get; }
        
        /// <summary>
        /// The Mode_formation entities repository.
        /// </summary>
		IRepository<Mode_formation, int> Mode_formation { get; }
        
        /// <summary>
        /// The Promo entities repository.
        /// </summary>
		IRepository<Promo, int> Promoes { get; }
        
        /// <summary>
        /// The Decision entities repository.
        /// </summary>
		IRepository<Decision, int> Decisions { get; }
        
        /// <summary>
        /// The Proce_verbal_delibation entities repository.
        /// </summary>
		IRepository<Proce_verbal_delibation, int> Proce_verbal_delibation { get; }
        
        /// <summary>
        /// The PARTICIPE entities repository.
        /// </summary>
		IRepository<PARTICIPE, Tuple<int, int>> PARTICIPEs { get; }
        
        /// <summary>
        /// The Semestre entities repository.
        /// </summary>
		IRepository<Semestre, int> Semestres { get; }
        
        /// <summary>
        /// The Section entities repository.
        /// </summary>
		IRepository<Section, int> Sections { get; }
        
        /// <summary>
        /// The Option entities repository.
        /// </summary>
		IRepository<Option, int> Options { get; }
        
        /// <summary>
        /// The Module entities repository.
        /// </summary>
		IRepository<Module, int> Modules { get; }
        
        /// <summary>
        /// The Specialite entities repository.
        /// </summary>
		IRepository<Specialite, int> Specialites { get; }
        
        /// <summary>
        /// The Branch entities repository.
        /// </summary>
		IRepository<Branch, string> Branches { get; }
        
        /// <summary>
        /// The Stagiair entities repository.
        /// </summary>
		IRepository<Stagiair, string> Stagiairs { get; }
        
        /// <summary>
        /// The Avenant_contrat_prorogation entities repository.
        /// </summary>
		IRepository<Avenant_contrat_prorogation, Tuple<string, int>> Avenant_contrat_prorogation { get; }
        
        /// <summary>
        /// The Employeur entities repository.
        /// </summary>
		IRepository<Employeur, int> Employeurs { get; }
        
        /// <summary>
        /// The Code_Postal entities repository.
        /// </summary>
		IRepository<Code_Postal, int> Code_Postal { get; }
        
        /// <summary>
        /// The Commune entities repository.
        /// </summary>
		IRepository<Commune, int> Communes { get; }
        
        /// <summary>
        /// The Maitre_Apprentissage entities repository.
        /// </summary>
		IRepository<Maitre_Apprentissage, int> Maitre_Apprentissage { get; }
        
        /// <summary>
        /// The Willaya entities repository.
        /// </summary>
		IRepository<Willaya, int> Willayas { get; }
        
        /// <summary>
        /// The Etablissement entities repository.
        /// </summary>
		IRepository<Etablissement, int> Etablissements { get; }
        
        /// <summary>
        /// The Transferer entities repository.
        /// </summary>
		IRepository<Transferer, Tuple<int, string>> Transferers { get; }
        
        /// <summary>
        /// The Contract_avenant_changement entities repository.
        /// </summary>
		IRepository<Contract_avenant_changement, Tuple<int, string>> Contract_avenant_changement { get; }
        
        /// <summary>
        /// The Suiver_stagiaire entities repository.
        /// </summary>
		IRepository<Suiver_stagiaire, Tuple<string, int, int>> Suiver_stagiaire { get; }
        
        /// <summary>
        /// The tuteur entities repository.
        /// </summary>
		IRepository<tuteur, int> tuteurs { get; }
        
        /// <summary>
        /// The C__MigrationHistory entities repository.
        /// </summary>
		IRepository<C__MigrationHistory, Tuple<string, string>> C__MigrationHistory { get; }
        
        /// <summary>
        /// The sysdiagram entities repository.
        /// </summary>
		IRepository<sysdiagram, int> sysdiagrams { get; }
    }
}
