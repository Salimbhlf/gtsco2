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
    /// Represents the single annee_scolaire object view model.
    /// </summary>
    public partial class annee_scolaireViewModel : SingleObjectViewModel<annee_scolaire, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of annee_scolaireViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static annee_scolaireViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new annee_scolaireViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the annee_scolaireViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the annee_scolaireViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected annee_scolaireViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.annee_scolaire, x => x.Designation) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Absences for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Absence> LookUpAbsences {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (annee_scolaireViewModel x) => x.LookUpAbsences,
                    getRepositoryFunc: x => x.Absences);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Evaluations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Evaluation> LookUpEvaluations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (annee_scolaireViewModel x) => x.LookUpEvaluations,
                    getRepositoryFunc: x => x.Evaluations);
            }
        }


        /// <summary>
        /// The view model for the annee_scolaireAbsences detail collection.
        /// </summary>
        public CollectionViewModelBase<Absence, Absence, int, IgtscoUnitOfWork> annee_scolaireAbsencesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (annee_scolaireViewModel x) => x.annee_scolaireAbsencesDetails,
                    getRepositoryFunc: x => x.Absences,
                    foreignKeyExpression: x => x.ID_Année_SCO,
                    navigationExpression: x => x.annee_scolaire);
            }
        }

        /// <summary>
        /// The view model for the annee_scolaireEvaluations detail collection.
        /// </summary>
        public CollectionViewModelBase<Evaluation, Evaluation, Tuple<string, int, int, int>, IgtscoUnitOfWork> annee_scolaireEvaluationsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (annee_scolaireViewModel x) => x.annee_scolaireEvaluationsDetails,
                    getRepositoryFunc: x => x.Evaluations,
                    foreignKeyExpression: x => x.ID_Année_SCO,
                    navigationExpression: x => x.annee_scolaire);
            }
        }
    }
}
