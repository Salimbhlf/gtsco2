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
    /// Represents the single Employeur object view model.
    /// </summary>
    public partial class EmployeurViewModel : SingleObjectViewModel<Employeur, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EmployeurViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EmployeurViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new EmployeurViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the EmployeurViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EmployeurViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EmployeurViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Employeurs, x => x.Type_Emp) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EmployeurViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Avenant_contrat_prorogation for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Avenant_contrat_prorogation> LookUpAvenant_contrat_prorogation {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EmployeurViewModel x) => x.LookUpAvenant_contrat_prorogation,
                    getRepositoryFunc: x => x.Avenant_contrat_prorogation);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Code_Postal for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Code_Postal> LookUpCode_Postal {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EmployeurViewModel x) => x.LookUpCode_Postal,
                    getRepositoryFunc: x => x.Code_Postal);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Maitre_Apprentissage for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Maitre_Apprentissage> LookUpMaitre_Apprentissage {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EmployeurViewModel x) => x.LookUpMaitre_Apprentissage,
                    getRepositoryFunc: x => x.Maitre_Apprentissage);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Contract_avenant_changement for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Contract_avenant_changement> LookUpContract_avenant_changement {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EmployeurViewModel x) => x.LookUpContract_avenant_changement,
                    getRepositoryFunc: x => x.Contract_avenant_changement);
            }
        }


        /// <summary>
        /// The view model for the EmployeurStagiairs detail collection.
        /// </summary>
        public CollectionViewModelBase<Stagiair, Stagiair, string, IgtscoUnitOfWork> EmployeurStagiairsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EmployeurViewModel x) => x.EmployeurStagiairsDetails,
                    getRepositoryFunc: x => x.Stagiairs,
                    foreignKeyExpression: x => x.ID_Emp,
                    navigationExpression: x => x.Employeur);
            }
        }

        /// <summary>
        /// The view model for the EmployeurAvenant_contrat_prorogation detail collection.
        /// </summary>
        public CollectionViewModelBase<Avenant_contrat_prorogation, Avenant_contrat_prorogation, Tuple<string, int>, IgtscoUnitOfWork> EmployeurAvenant_contrat_prorogationDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EmployeurViewModel x) => x.EmployeurAvenant_contrat_prorogationDetails,
                    getRepositoryFunc: x => x.Avenant_contrat_prorogation,
                    foreignKeyExpression: x => x.ID_emp,
                    navigationExpression: x => x.Employeur);
            }
        }

        /// <summary>
        /// The view model for the EmployeurMaitre_Apprentissage detail collection.
        /// </summary>
        public CollectionViewModelBase<Maitre_Apprentissage, Maitre_Apprentissage, int, IgtscoUnitOfWork> EmployeurMaitre_ApprentissageDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EmployeurViewModel x) => x.EmployeurMaitre_ApprentissageDetails,
                    getRepositoryFunc: x => x.Maitre_Apprentissage,
                    foreignKeyExpression: x => x.ID_Emp,
                    navigationExpression: x => x.Employeur);
            }
        }

        /// <summary>
        /// The view model for the EmployeurContract_avenant_changement detail collection.
        /// </summary>
        public CollectionViewModelBase<Contract_avenant_changement, Contract_avenant_changement, Tuple<int, string>, IgtscoUnitOfWork> EmployeurContract_avenant_changementDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EmployeurViewModel x) => x.EmployeurContract_avenant_changementDetails,
                    getRepositoryFunc: x => x.Contract_avenant_changement,
                    foreignKeyExpression: x => x.id_emp,
                    navigationExpression: x => x.Employeur);
            }
        }
    }
}
