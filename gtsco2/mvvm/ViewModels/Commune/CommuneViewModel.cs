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
    /// Represents the single Commune object view model.
    /// </summary>
    public partial class CommuneViewModel : SingleObjectViewModel<Commune, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CommuneViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CommuneViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CommuneViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CommuneViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CommuneViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CommuneViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Communes, x => x.Commune_name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CommuneViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Code_Postal for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Code_Postal> LookUpCode_Postal {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CommuneViewModel x) => x.LookUpCode_Postal,
                    getRepositoryFunc: x => x.Code_Postal);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Willayas for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Willaya> LookUpWillayas {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CommuneViewModel x) => x.LookUpWillayas,
                    getRepositoryFunc: x => x.Willayas);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Maitre_Apprentissage for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Maitre_Apprentissage> LookUpMaitre_Apprentissage {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CommuneViewModel x) => x.LookUpMaitre_Apprentissage,
                    getRepositoryFunc: x => x.Maitre_Apprentissage);
            }
        }


        /// <summary>
        /// The view model for the CommuneStagiairs detail collection.
        /// </summary>
        public CollectionViewModelBase<Stagiair, Stagiair, string, IgtscoUnitOfWork> CommuneStagiairsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CommuneViewModel x) => x.CommuneStagiairsDetails,
                    getRepositoryFunc: x => x.Stagiairs,
                    foreignKeyExpression: x => x.Lieu_Naissance,
                    navigationExpression: x => x.Commune);
            }
        }

        /// <summary>
        /// The view model for the CommuneCode_Postal detail collection.
        /// </summary>
        public CollectionViewModelBase<Code_Postal, Code_Postal, int, IgtscoUnitOfWork> CommuneCode_PostalDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CommuneViewModel x) => x.CommuneCode_PostalDetails,
                    getRepositoryFunc: x => x.Code_Postal,
                    foreignKeyExpression: x => x.Commune_id,
                    navigationExpression: x => x.Commune);
            }
        }

        /// <summary>
        /// The view model for the CommuneMaitre_Apprentissage detail collection.
        /// </summary>
        public CollectionViewModelBase<Maitre_Apprentissage, Maitre_Apprentissage, int, IgtscoUnitOfWork> CommuneMaitre_ApprentissageDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CommuneViewModel x) => x.CommuneMaitre_ApprentissageDetails,
                    getRepositoryFunc: x => x.Maitre_Apprentissage,
                    foreignKeyExpression: x => x.Commune_Maitre_Apprentissage,
                    navigationExpression: x => x.Commune);
            }
        }
    }
}
