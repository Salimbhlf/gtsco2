using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using gtsco2.mvvm.gtscoDataModel;
using gtsco2.mvvm.Common;
using gtsco2.basededonne;

namespace gtsco2.mvvm.ViewModels {

    /// <summary>
    /// Represents the single Stagiair object view model.
    /// </summary>
    public partial class StagiairViewModel : SingleObjectViewModel<Stagiair, string, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of StagiairViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static StagiairViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new StagiairViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the StagiairViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StagiairViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected StagiairViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Stagiairs, x => x.Num_STG) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Absences for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Absence> LookUpAbsences {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpAbsences,
                    getRepositoryFunc: x => x.Absences);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Evaluations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Evaluation> LookUpEvaluations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpEvaluations,
                    getRepositoryFunc: x => x.Evaluations);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Decisions for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Decision> LookUpDecisions {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpDecisions,
                    getRepositoryFunc: x => x.Decisions);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Code_Postal for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Code_Postal> LookUpCode_Postal {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpCode_Postal,
                    getRepositoryFunc: x => x.Code_Postal);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Communes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Commune> LookUpCommunes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpCommunes,
                    getRepositoryFunc: x => x.Communes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Employeurs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employeur> LookUpEmployeurs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpEmployeurs,
                    getRepositoryFunc: x => x.Employeurs);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Etablissements for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Etablissement> LookUpEtablissements {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpEtablissements,
                    getRepositoryFunc: x => x.Etablissements);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Maitre_Apprentissage for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Maitre_Apprentissage> LookUpMaitre_Apprentissage {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpMaitre_Apprentissage,
                    getRepositoryFunc: x => x.Maitre_Apprentissage);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Promoes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Promo> LookUpPromoes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpPromoes,
                    getRepositoryFunc: x => x.Promoes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Sections for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Section> LookUpSections {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpSections,
                    getRepositoryFunc: x => x.Sections);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of tuteurs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<tuteur> LookUptuteurs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUptuteurs,
                    getRepositoryFunc: x => x.tuteurs);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Avenant_contrat_prorogation for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Avenant_contrat_prorogation> LookUpAvenant_contrat_prorogation {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpAvenant_contrat_prorogation,
                    getRepositoryFunc: x => x.Avenant_contrat_prorogation);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Transferers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Transferer> LookUpTransferers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpTransferers,
                    getRepositoryFunc: x => x.Transferers);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Contract_avenant_changement for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Contract_avenant_changement> LookUpContract_avenant_changement {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpContract_avenant_changement,
                    getRepositoryFunc: x => x.Contract_avenant_changement);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Suiver_stagiaire for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Suiver_stagiaire> LookUpSuiver_stagiaire {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StagiairViewModel x) => x.LookUpSuiver_stagiaire,
                    getRepositoryFunc: x => x.Suiver_stagiaire);
            }
        }


        /// <summary>
        /// The view model for the StagiairAbsences detail collection.
        /// </summary>
        public CollectionViewModelBase<Absence, Absence, int, IgtscoUnitOfWork> StagiairAbsencesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (StagiairViewModel x) => x.StagiairAbsencesDetails,
                    getRepositoryFunc: x => x.Absences,
                    foreignKeyExpression: x => x.Num_STG,
                    navigationExpression: x => x.Stagiair);
            }
        }

        /// <summary>
        /// The view model for the StagiairEvaluations detail collection.
        /// </summary>
        public CollectionViewModelBase<Evaluation, Evaluation, Tuple<string, int, int, int>, IgtscoUnitOfWork> StagiairEvaluationsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (StagiairViewModel x) => x.StagiairEvaluationsDetails,
                    getRepositoryFunc: x => x.Evaluations,
                    foreignKeyExpression: x => x.Num_STG,
                    navigationExpression: x => x.Stagiair);
            }
        }

        /// <summary>
        /// The view model for the StagiairDecisions detail collection.
        /// </summary>
        public CollectionViewModelBase<Decision, Decision, int, IgtscoUnitOfWork> StagiairDecisionsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (StagiairViewModel x) => x.StagiairDecisionsDetails,
                    getRepositoryFunc: x => x.Decisions,
                    foreignKeyExpression: x => x.Num_STG,
                    navigationExpression: x => x.Stagiair);
            }
        }

        /// <summary>
        /// The view model for the StagiairAvenant_contrat_prorogation detail collection.
        /// </summary>
        public CollectionViewModelBase<Avenant_contrat_prorogation, Avenant_contrat_prorogation, Tuple<string, int>, IgtscoUnitOfWork> StagiairAvenant_contrat_prorogationDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (StagiairViewModel x) => x.StagiairAvenant_contrat_prorogationDetails,
                    getRepositoryFunc: x => x.Avenant_contrat_prorogation,
                    foreignKeyExpression: x => x.Num_stg,
                    navigationExpression: x => x.Stagiair);
            }
        }

        /// <summary>
        /// The view model for the StagiairTransferers detail collection.
        /// </summary>
        public CollectionViewModelBase<Transferer, Transferer, Tuple<int, string>, IgtscoUnitOfWork> StagiairTransferersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (StagiairViewModel x) => x.StagiairTransferersDetails,
                    getRepositoryFunc: x => x.Transferers,
                    foreignKeyExpression: x => x.num_stg,
                    navigationExpression: x => x.Stagiair);
            }
        }

        /// <summary>
        /// The view model for the StagiairContract_avenant_changement detail collection.
        /// </summary>
        public CollectionViewModelBase<Contract_avenant_changement, Contract_avenant_changement, Tuple<int, string>, IgtscoUnitOfWork> StagiairContract_avenant_changementDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (StagiairViewModel x) => x.StagiairContract_avenant_changementDetails,
                    getRepositoryFunc: x => x.Contract_avenant_changement,
                    foreignKeyExpression: x => x.num_stg,
                    navigationExpression: x => x.Stagiair);
            }
        }

        /// <summary>
        /// The view model for the StagiairSuiver_stagiaire detail collection.
        /// </summary>
        public CollectionViewModelBase<Suiver_stagiaire, Suiver_stagiaire, Tuple<string, int, int>, IgtscoUnitOfWork> StagiairSuiver_stagiaireDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (StagiairViewModel x) => x.StagiairSuiver_stagiaireDetails,
                    getRepositoryFunc: x => x.Suiver_stagiaire,
                    foreignKeyExpression: x => x.num_stg,
                    navigationExpression: x => x.Stagiair);
            }
        }
    }
}
