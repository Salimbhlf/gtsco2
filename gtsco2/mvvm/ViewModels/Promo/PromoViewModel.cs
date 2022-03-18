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
    /// Represents the single Promo object view model.
    /// </summary>
    public partial class PromoViewModel : SingleObjectViewModel<Promo, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PromoViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PromoViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PromoViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PromoViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PromoViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PromoViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Promoes, x => x.Code_Promo) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Mode_formation for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Mode_formation> LookUpMode_formation {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PromoViewModel x) => x.LookUpMode_formation,
                    getRepositoryFunc: x => x.Mode_formation);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Options for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Option> LookUpOptions {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PromoViewModel x) => x.LookUpOptions,
                    getRepositoryFunc: x => x.Options);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Decisions for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Decision> LookUpDecisions {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PromoViewModel x) => x.LookUpDecisions,
                    getRepositoryFunc: x => x.Decisions);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Sections for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Section> LookUpSections {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PromoViewModel x) => x.LookUpSections,
                    getRepositoryFunc: x => x.Sections);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PromoViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }


        /// <summary>
        /// The view model for the PromoDecisions detail collection.
        /// </summary>
        public CollectionViewModelBase<Decision, Decision, int, IgtscoUnitOfWork> PromoDecisionsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PromoViewModel x) => x.PromoDecisionsDetails,
                    getRepositoryFunc: x => x.Decisions,
                    foreignKeyExpression: x => x.ID_Promo,
                    navigationExpression: x => x.Promo);
            }
        }

        /// <summary>
        /// The view model for the PromoSections detail collection.
        /// </summary>
        public CollectionViewModelBase<Section, Section, int, IgtscoUnitOfWork> PromoSectionsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PromoViewModel x) => x.PromoSectionsDetails,
                    getRepositoryFunc: x => x.Sections,
                    foreignKeyExpression: x => x.ID_Promo,
                    navigationExpression: x => x.Promo);
            }
        }

        /// <summary>
        /// The view model for the PromoStagiairs detail collection.
        /// </summary>
        public CollectionViewModelBase<Stagiair, Stagiair, string, IgtscoUnitOfWork> PromoStagiairsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PromoViewModel x) => x.PromoStagiairsDetails,
                    getRepositoryFunc: x => x.Stagiairs,
                    foreignKeyExpression: x => x.ID_Promo,
                    navigationExpression: x => x.Promo);
            }
        }
    }
}
