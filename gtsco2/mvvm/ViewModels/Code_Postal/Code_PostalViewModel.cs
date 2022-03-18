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
    /// Represents the single Code_Postal object view model.
    /// </summary>
    public partial class Code_PostalViewModel : SingleObjectViewModel<Code_Postal, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Code_PostalViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Code_PostalViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Code_PostalViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Code_PostalViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Code_PostalViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Code_PostalViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Code_Postal, x => x.post_Adresse_ar) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Code_PostalViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Employeurs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employeur> LookUpEmployeurs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Code_PostalViewModel x) => x.LookUpEmployeurs,
                    getRepositoryFunc: x => x.Employeurs);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Communes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Commune> LookUpCommunes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Code_PostalViewModel x) => x.LookUpCommunes,
                    getRepositoryFunc: x => x.Communes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Etablissements for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Etablissement> LookUpEtablissements {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Code_PostalViewModel x) => x.LookUpEtablissements,
                    getRepositoryFunc: x => x.Etablissements);
            }
        }


        /// <summary>
        /// The view model for the Code_PostalStagiairs detail collection.
        /// </summary>
        public CollectionViewModelBase<Stagiair, Stagiair, string, IgtscoUnitOfWork> Code_PostalStagiairsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Code_PostalViewModel x) => x.Code_PostalStagiairsDetails,
                    getRepositoryFunc: x => x.Stagiairs,
                    foreignKeyExpression: x => x.Code_postal,
                    navigationExpression: x => x.Code_Postal1);
            }
        }

        /// <summary>
        /// The view model for the Code_PostalEmployeurs detail collection.
        /// </summary>
        public CollectionViewModelBase<Employeur, Employeur, int, IgtscoUnitOfWork> Code_PostalEmployeursDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Code_PostalViewModel x) => x.Code_PostalEmployeursDetails,
                    getRepositoryFunc: x => x.Employeurs,
                    foreignKeyExpression: x => x.Code_Postal_Emp,
                    navigationExpression: x => x.Code_Postal);
            }
        }

        /// <summary>
        /// The view model for the Code_PostalEtablissements detail collection.
        /// </summary>
        public CollectionViewModelBase<Etablissement, Etablissement, int, IgtscoUnitOfWork> Code_PostalEtablissementsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Code_PostalViewModel x) => x.Code_PostalEtablissementsDetails,
                    getRepositoryFunc: x => x.Etablissements,
                    foreignKeyExpression: x => x.Code_Postal_EATB,
                    navigationExpression: x => x.Code_Postal);
            }
        }
    }
}
