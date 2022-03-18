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
    /// Represents the single Option object view model.
    /// </summary>
    public partial class OptionViewModel : SingleObjectViewModel<Option, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OptionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OptionViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OptionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OptionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OptionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OptionViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Options, x => x.Code_Option) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Promoes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Promo> LookUpPromoes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OptionViewModel x) => x.LookUpPromoes,
                    getRepositoryFunc: x => x.Promoes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Sections for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Section> LookUpSections {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OptionViewModel x) => x.LookUpSections,
                    getRepositoryFunc: x => x.Sections);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Specialites for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Specialite> LookUpSpecialites {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OptionViewModel x) => x.LookUpSpecialites,
                    getRepositoryFunc: x => x.Specialites);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Modules for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Module> LookUpModules {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OptionViewModel x) => x.LookUpModules,
                    getRepositoryFunc: x => x.Modules);
            }
        }


        /// <summary>
        /// The view model for the OptionPromoes detail collection.
        /// </summary>
        public CollectionViewModelBase<Promo, Promo, int, IgtscoUnitOfWork> OptionPromoesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (OptionViewModel x) => x.OptionPromoesDetails,
                    getRepositoryFunc: x => x.Promoes,
                    foreignKeyExpression: x => x.ID_Option,
                    navigationExpression: x => x.Option);
            }
        }

        /// <summary>
        /// The view model for the OptionSections detail collection.
        /// </summary>
        public CollectionViewModelBase<Section, Section, int, IgtscoUnitOfWork> OptionSectionsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (OptionViewModel x) => x.OptionSectionsDetails,
                    getRepositoryFunc: x => x.Sections,
                    foreignKeyExpression: x => x.ID_Option,
                    navigationExpression: x => x.Option);
            }
        }

        /// <summary>
        /// The view model for the OptionModules detail collection.
        /// </summary>
        public CollectionViewModelBase<Module, Module, int, IgtscoUnitOfWork> OptionModulesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (OptionViewModel x) => x.OptionModulesDetails,
                    getRepositoryFunc: x => x.Modules,
                    foreignKeyExpression: x => x.ID_Option,
                    navigationExpression: x => x.Option);
            }
        }
    }
}
