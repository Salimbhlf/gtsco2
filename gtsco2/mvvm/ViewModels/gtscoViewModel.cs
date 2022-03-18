using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using gtsco2.mvvm.gtscoDataModel;

namespace gtsco2.mvvm.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the gtsco data model.
    /// </summary>
    public partial class gtscoViewModel : DocumentsViewModel<gtscoModuleDescription, IgtscoUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
	
        /// <summary>
        /// Creates a new instance of gtscoViewModel as a POCO view model.
        /// </summary>
        public static gtscoViewModel Create() {
            return ViewModelSource.Create(() => new gtscoViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the gtscoViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the gtscoViewModel type without the POCO proxy factory.
        /// </summary>
        protected gtscoViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override gtscoModuleDescription[] CreateModules() {
			return new gtscoModuleDescription[] {
                new gtscoModuleDescription( "Absences", "AbsenceCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Absences)),
                new gtscoModuleDescription( "annee scolaire", "annee_scolaireCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.annee_scolaire)),
                new gtscoModuleDescription( "Evaluations", "EvaluationCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Evaluations)),
                new gtscoModuleDescription( "Enseignants", "EnseignantCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Enseignants)),
                new gtscoModuleDescription( "Mode formation", "Mode_formationCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Mode_formation)),
                new gtscoModuleDescription( "Promoes", "PromoCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Promoes)),
                new gtscoModuleDescription( "Decisions", "DecisionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Decisions)),
                new gtscoModuleDescription( "Proce verbal delibation", "Proce_verbal_delibationCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Proce_verbal_delibation)),
                new gtscoModuleDescription( "PARTICIPEs", "PARTICIPECollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.PARTICIPEs)),
                new gtscoModuleDescription( "Semestres", "SemestreCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Semestres)),
                new gtscoModuleDescription( "Sections", "SectionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Sections)),
                new gtscoModuleDescription( "Options", "OptionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Options)),
                new gtscoModuleDescription( "Modules", "ModuleCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Modules)),
                new gtscoModuleDescription( "Specialites", "SpecialiteCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Specialites)),
                new gtscoModuleDescription( "Branches", "BranchCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Branches)),
                new gtscoModuleDescription( "Stagiairs", "StagiairCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Stagiairs)),
                new gtscoModuleDescription( "Avenant contrat prorogation", "Avenant_contrat_prorogationCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Avenant_contrat_prorogation)),
                new gtscoModuleDescription( "Employeurs", "EmployeurCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Employeurs)),
                new gtscoModuleDescription( "Code Postal", "Code_PostalCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Code_Postal)),
                new gtscoModuleDescription( "Communes", "CommuneCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Communes)),
                new gtscoModuleDescription( "Maitre Apprentissage", "Maitre_ApprentissageCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Maitre_Apprentissage)),
                new gtscoModuleDescription( "Willayas", "WillayaCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Willayas)),
                new gtscoModuleDescription( "Etablissements", "EtablissementCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Etablissements)),
                new gtscoModuleDescription( "Transferers", "TransfererCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Transferers)),
                new gtscoModuleDescription( "Contract avenant changement", "Contract_avenant_changementCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Contract_avenant_changement)),
                new gtscoModuleDescription( "Suiver stagiaire", "Suiver_stagiaireCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Suiver_stagiaire)),
                new gtscoModuleDescription( "tuteurs", "tuteurCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.tuteurs)),
			};
        }
                	}

    public partial class gtscoModuleDescription : ModuleDescription<gtscoModuleDescription> {
        public gtscoModuleDescription(string title, string documentType, string group, Func<gtscoModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}