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
    /// Represents the single Semestre object view model.
    /// </summary>
    public partial class SemestreViewModel : SingleObjectViewModel<Semestre, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SemestreViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SemestreViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SemestreViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SemestreViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SemestreViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SemestreViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Semestres, x => x.Designation_Semestre) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Absences for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Absence> LookUpAbsences {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SemestreViewModel x) => x.LookUpAbsences,
                    getRepositoryFunc: x => x.Absences);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Evaluations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Evaluation> LookUpEvaluations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SemestreViewModel x) => x.LookUpEvaluations,
                    getRepositoryFunc: x => x.Evaluations);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Decisions for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Decision> LookUpDecisions {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SemestreViewModel x) => x.LookUpDecisions,
                    getRepositoryFunc: x => x.Decisions);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Sections for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Section> LookUpSections {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SemestreViewModel x) => x.LookUpSections,
                    getRepositoryFunc: x => x.Sections);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Suiver_stagiaire for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Suiver_stagiaire> LookUpSuiver_stagiaire {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SemestreViewModel x) => x.LookUpSuiver_stagiaire,
                    getRepositoryFunc: x => x.Suiver_stagiaire);
            }
        }


        /// <summary>
        /// The view model for the SemestreAbsences detail collection.
        /// </summary>
        public CollectionViewModelBase<Absence, Absence, int, IgtscoUnitOfWork> SemestreAbsencesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SemestreViewModel x) => x.SemestreAbsencesDetails,
                    getRepositoryFunc: x => x.Absences,
                    foreignKeyExpression: x => x.ID_Semestre,
                    navigationExpression: x => x.Semestre);
            }
        }

        /// <summary>
        /// The view model for the SemestreEvaluations detail collection.
        /// </summary>
        public CollectionViewModelBase<Evaluation, Evaluation, Tuple<string, int, int, int>, IgtscoUnitOfWork> SemestreEvaluationsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SemestreViewModel x) => x.SemestreEvaluationsDetails,
                    getRepositoryFunc: x => x.Evaluations,
                    foreignKeyExpression: x => x.ID_Semestre,
                    navigationExpression: x => x.Semestre);
            }
        }

        /// <summary>
        /// The view model for the SemestreDecisions detail collection.
        /// </summary>
        public CollectionViewModelBase<Decision, Decision, int, IgtscoUnitOfWork> SemestreDecisionsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SemestreViewModel x) => x.SemestreDecisionsDetails,
                    getRepositoryFunc: x => x.Decisions,
                    foreignKeyExpression: x => x.ID_Semestre,
                    navigationExpression: x => x.Semestre);
            }
        }

        /// <summary>
        /// The view model for the SemestreSections detail collection.
        /// </summary>
        public CollectionViewModelBase<Section, Section, int, IgtscoUnitOfWork> SemestreSectionsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SemestreViewModel x) => x.SemestreSectionsDetails,
                    getRepositoryFunc: x => x.Sections,
                    foreignKeyExpression: x => x.Semestre_en_coure,
                    navigationExpression: x => x.Semestre);
            }
        }

        /// <summary>
        /// The view model for the SemestreSuiver_stagiaire detail collection.
        /// </summary>
        public CollectionViewModelBase<Suiver_stagiaire, Suiver_stagiaire, Tuple<string, int, int>, IgtscoUnitOfWork> SemestreSuiver_stagiaireDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SemestreViewModel x) => x.SemestreSuiver_stagiaireDetails,
                    getRepositoryFunc: x => x.Suiver_stagiaire,
                    foreignKeyExpression: x => x.semestre,
                    navigationExpression: x => x.Semestre1);
            }
        }
    }
}
