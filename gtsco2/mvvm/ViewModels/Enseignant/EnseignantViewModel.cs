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
    /// Represents the single Enseignant object view model.
    /// </summary>
    public partial class EnseignantViewModel : SingleObjectViewModel<Enseignant, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EnseignantViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EnseignantViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new EnseignantViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the EnseignantViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EnseignantViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EnseignantViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Enseignants, x => x.Nom) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Evaluations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Evaluation> LookUpEvaluations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EnseignantViewModel x) => x.LookUpEvaluations,
                    getRepositoryFunc: x => x.Evaluations);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Mode_formation for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Mode_formation> LookUpMode_formation {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EnseignantViewModel x) => x.LookUpMode_formation,
                    getRepositoryFunc: x => x.Mode_formation);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of PARTICIPEs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<PARTICIPE> LookUpPARTICIPEs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EnseignantViewModel x) => x.LookUpPARTICIPEs,
                    getRepositoryFunc: x => x.PARTICIPEs);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Suiver_stagiaire for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Suiver_stagiaire> LookUpSuiver_stagiaire {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EnseignantViewModel x) => x.LookUpSuiver_stagiaire,
                    getRepositoryFunc: x => x.Suiver_stagiaire);
            }
        }


        /// <summary>
        /// The view model for the EnseignantEvaluations detail collection.
        /// </summary>
        public CollectionViewModelBase<Evaluation, Evaluation, Tuple<string, int, int, int>, IgtscoUnitOfWork> EnseignantEvaluationsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EnseignantViewModel x) => x.EnseignantEvaluationsDetails,
                    getRepositoryFunc: x => x.Evaluations,
                    foreignKeyExpression: x => x.Enseignant,
                    navigationExpression: x => x.Enseignant1);
            }
        }

        /// <summary>
        /// The view model for the EnseignantPARTICIPEs detail collection.
        /// </summary>
        public CollectionViewModelBase<PARTICIPE, PARTICIPE, Tuple<int, int>, IgtscoUnitOfWork> EnseignantPARTICIPEsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EnseignantViewModel x) => x.EnseignantPARTICIPEsDetails,
                    getRepositoryFunc: x => x.PARTICIPEs,
                    foreignKeyExpression: x => x.id_Enseignant,
                    navigationExpression: x => x.Enseignant);
            }
        }

        /// <summary>
        /// The view model for the EnseignantSuiver_stagiaire detail collection.
        /// </summary>
        public CollectionViewModelBase<Suiver_stagiaire, Suiver_stagiaire, Tuple<string, int, int>, IgtscoUnitOfWork> EnseignantSuiver_stagiaireDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EnseignantViewModel x) => x.EnseignantSuiver_stagiaireDetails,
                    getRepositoryFunc: x => x.Suiver_stagiaire,
                    foreignKeyExpression: x => x.Enseignant,
                    navigationExpression: x => x.Enseignant1);
            }
        }
    }
}
