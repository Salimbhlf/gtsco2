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
    /// Represents the single Section object view model.
    /// </summary>
    public partial class SectionViewModel : SingleObjectViewModel<Section, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SectionViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SectionViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Sections, x => x.Code_Section) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Mode_formation for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Mode_formation> LookUpMode_formation {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SectionViewModel x) => x.LookUpMode_formation,
                    getRepositoryFunc: x => x.Mode_formation);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Options for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Option> LookUpOptions {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SectionViewModel x) => x.LookUpOptions,
                    getRepositoryFunc: x => x.Options);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Promoes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Promo> LookUpPromoes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SectionViewModel x) => x.LookUpPromoes,
                    getRepositoryFunc: x => x.Promoes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Semestres for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Semestre> LookUpSemestres {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SectionViewModel x) => x.LookUpSemestres,
                    getRepositoryFunc: x => x.Semestres);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SectionViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }


        /// <summary>
        /// The view model for the SectionStagiairs detail collection.
        /// </summary>
        public CollectionViewModelBase<Stagiair, Stagiair, string, IgtscoUnitOfWork> SectionStagiairsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SectionViewModel x) => x.SectionStagiairsDetails,
                    getRepositoryFunc: x => x.Stagiairs,
                    foreignKeyExpression: x => x.Section,
                    navigationExpression: x => x.Section1);
            }
        }
    }
}
