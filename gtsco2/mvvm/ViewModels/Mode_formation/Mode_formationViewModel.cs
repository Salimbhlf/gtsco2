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
    /// Represents the single Mode_formation object view model.
    /// </summary>
    public partial class Mode_formationViewModel : SingleObjectViewModel<Mode_formation, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Mode_formationViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Mode_formationViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Mode_formationViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Mode_formationViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Mode_formationViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Mode_formationViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Mode_formation, x => x.Code_Mode_Formation) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Enseignants for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Enseignant> LookUpEnseignants {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Mode_formationViewModel x) => x.LookUpEnseignants,
                    getRepositoryFunc: x => x.Enseignants);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Promoes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Promo> LookUpPromoes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Mode_formationViewModel x) => x.LookUpPromoes,
                    getRepositoryFunc: x => x.Promoes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Sections for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Section> LookUpSections {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Mode_formationViewModel x) => x.LookUpSections,
                    getRepositoryFunc: x => x.Sections);
            }
        }


        /// <summary>
        /// The view model for the Mode_formationEnseignants detail collection.
        /// </summary>
        public CollectionViewModelBase<Enseignant, Enseignant, int, IgtscoUnitOfWork> Mode_formationEnseignantsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Mode_formationViewModel x) => x.Mode_formationEnseignantsDetails,
                    getRepositoryFunc: x => x.Enseignants,
                    foreignKeyExpression: x => x.Mode_Formation,
                    navigationExpression: x => x.Mode_formation1);
            }
        }

        /// <summary>
        /// The view model for the Mode_formationPromoes detail collection.
        /// </summary>
        public CollectionViewModelBase<Promo, Promo, int, IgtscoUnitOfWork> Mode_formationPromoesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Mode_formationViewModel x) => x.Mode_formationPromoesDetails,
                    getRepositoryFunc: x => x.Promoes,
                    foreignKeyExpression: x => x.Mode_de_formation,
                    navigationExpression: x => x.Mode_formation);
            }
        }

        /// <summary>
        /// The view model for the Mode_formationSections detail collection.
        /// </summary>
        public CollectionViewModelBase<Section, Section, int, IgtscoUnitOfWork> Mode_formationSectionsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Mode_formationViewModel x) => x.Mode_formationSectionsDetails,
                    getRepositoryFunc: x => x.Sections,
                    foreignKeyExpression: x => x.ID_Mode_Formation,
                    navigationExpression: x => x.Mode_formation);
            }
        }
    }
}
