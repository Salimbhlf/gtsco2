using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using gtsco2.basededonne;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gtsco2.mvvm.gtscoDataModel {

    /// <summary>
    /// A gtscoUnitOfWork instance that represents the run-time implementation of the IgtscoUnitOfWork interface.
    /// </summary>
    public class gtscoUnitOfWork : DbUnitOfWork<gtsco>, IgtscoUnitOfWork {

        public gtscoUnitOfWork(Func<gtsco> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Absence, int> IgtscoUnitOfWork.Absences {
            get { return GetRepository(x => x.Set<Absence>(), (Absence x) => x.ID_Absence); }
        }

        IRepository<annee_scolaire, int> IgtscoUnitOfWork.annee_scolaire {
            get { return GetRepository(x => x.Set<annee_scolaire>(), (annee_scolaire x) => x.ID_Année_SCO); }
        }

        IRepository<Evaluation, Tuple<string, int, int, int>> IgtscoUnitOfWork.Evaluations {
            get { return GetRepository(x => x.Set<Evaluation>(), (Evaluation x) => Tuple.Create(x.Num_STG, x.ID_Semestre, x.ID_Année_SCO, x.ID_Module)); }
        }

        IRepository<Enseignant, int> IgtscoUnitOfWork.Enseignants {
            get { return GetRepository(x => x.Set<Enseignant>(), (Enseignant x) => x.id_Enseignant); }
        }

        IRepository<Mode_formation, int> IgtscoUnitOfWork.Mode_formation {
            get { return GetRepository(x => x.Set<Mode_formation>(), (Mode_formation x) => x.ID_Mode_Formation); }
        }

        IRepository<Promo, int> IgtscoUnitOfWork.Promoes {
            get { return GetRepository(x => x.Set<Promo>(), (Promo x) => x.ID_Promo); }
        }

        IRepository<Decision, int> IgtscoUnitOfWork.Decisions {
            get { return GetRepository(x => x.Set<Decision>(), (Decision x) => x.ID_Decision); }
        }

        IRepository<Proce_verbal_delibation, int> IgtscoUnitOfWork.Proce_verbal_delibation {
            get { return GetRepository(x => x.Set<Proce_verbal_delibation>(), (Proce_verbal_delibation x) => x.ID_PV_Délibiration); }
        }

        IRepository<PARTICIPE, Tuple<int, int>> IgtscoUnitOfWork.PARTICIPEs {
            get { return GetRepository(x => x.Set<PARTICIPE>(), (PARTICIPE x) => Tuple.Create(x.id_Enseignant, x.ID_PV_Délibiration)); }
        }

        IRepository<Semestre, int> IgtscoUnitOfWork.Semestres {
            get { return GetRepository(x => x.Set<Semestre>(), (Semestre x) => x.ID_Semestre); }
        }

        IRepository<Section, int> IgtscoUnitOfWork.Sections {
            get { return GetRepository(x => x.Set<Section>(), (Section x) => x.SectionID); }
        }

        IRepository<Option, int> IgtscoUnitOfWork.Options {
            get { return GetRepository(x => x.Set<Option>(), (Option x) => x.ID_Option); }
        }

        IRepository<Module, int> IgtscoUnitOfWork.Modules {
            get { return GetRepository(x => x.Set<Module>(), (Module x) => x.ID_Module); }
        }

        IRepository<Specialite, int> IgtscoUnitOfWork.Specialites {
            get { return GetRepository(x => x.Set<Specialite>(), (Specialite x) => x.ID_Specialité); }
        }

        IRepository<Branch, string> IgtscoUnitOfWork.Branches {
            get { return GetRepository(x => x.Set<Branch>(), (Branch x) => x.Code_Branche); }
        }

        IRepository<Stagiair, string> IgtscoUnitOfWork.Stagiairs {
            get { return GetRepository(x => x.Set<Stagiair>(), (Stagiair x) => x.Num_STG); }
        }

        IRepository<Avenant_contrat_prorogation, Tuple<string, int>> IgtscoUnitOfWork.Avenant_contrat_prorogation {
            get { return GetRepository(x => x.Set<Avenant_contrat_prorogation>(), (Avenant_contrat_prorogation x) => Tuple.Create(x.Num_stg, x.ID_emp)); }
        }

        IRepository<Employeur, int> IgtscoUnitOfWork.Employeurs {
            get { return GetRepository(x => x.Set<Employeur>(), (Employeur x) => x.ID_Emp); }
        }

        IRepository<Code_Postal, int> IgtscoUnitOfWork.Code_Postal {
            get { return GetRepository(x => x.Set<Code_Postal>(), (Code_Postal x) => x.ID_Code_Postal); }
        }

        IRepository<Commune, int> IgtscoUnitOfWork.Communes {
            get { return GetRepository(x => x.Set<Commune>(), (Commune x) => x.Commune_id); }
        }

        IRepository<Maitre_Apprentissage, int> IgtscoUnitOfWork.Maitre_Apprentissage {
            get { return GetRepository(x => x.Set<Maitre_Apprentissage>(), (Maitre_Apprentissage x) => x.ID_Maitre_Apprentissage); }
        }

        IRepository<Willaya, int> IgtscoUnitOfWork.Willayas {
            get { return GetRepository(x => x.Set<Willaya>(), (Willaya x) => x.Wilaya_Code); }
        }

        IRepository<Etablissement, int> IgtscoUnitOfWork.Etablissements {
            get { return GetRepository(x => x.Set<Etablissement>(), (Etablissement x) => x.ID_ETAB); }
        }

        IRepository<Transferer, Tuple<int, string>> IgtscoUnitOfWork.Transferers {
            get { return GetRepository(x => x.Set<Transferer>(), (Transferer x) => Tuple.Create(x.ID_etb, x.num_stg)); }
        }

        IRepository<Contract_avenant_changement, Tuple<int, string>> IgtscoUnitOfWork.Contract_avenant_changement {
            get { return GetRepository(x => x.Set<Contract_avenant_changement>(), (Contract_avenant_changement x) => Tuple.Create(x.id_emp, x.num_stg)); }
        }

        IRepository<Suiver_stagiaire, Tuple<string, int, int>> IgtscoUnitOfWork.Suiver_stagiaire {
            get { return GetRepository(x => x.Set<Suiver_stagiaire>(), (Suiver_stagiaire x) => Tuple.Create(x.num_stg, x.Enseignant, x.semestre)); }
        }

        IRepository<tuteur, int> IgtscoUnitOfWork.tuteurs {
            get { return GetRepository(x => x.Set<tuteur>(), (tuteur x) => x.id_tuteur); }
        }

        IRepository<C__MigrationHistory, Tuple<string, string>> IgtscoUnitOfWork.C__MigrationHistory {
            get { return GetRepository(x => x.Set<C__MigrationHistory>(), (C__MigrationHistory x) => Tuple.Create(x.MigrationId, x.ContextKey)); }
        }

        IRepository<sysdiagram, int> IgtscoUnitOfWork.sysdiagrams {
            get { return GetRepository(x => x.Set<sysdiagram>(), (sysdiagram x) => x.diagram_id); }
        }
    }
}
