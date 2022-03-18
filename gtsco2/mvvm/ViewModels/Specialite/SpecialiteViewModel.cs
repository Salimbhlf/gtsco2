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
    /// Represents the single Specialite object view model.
    /// </summary>
    public partial class SpecialiteViewModel : SingleObjectViewModel<Specialite, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SpecialiteViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SpecialiteViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SpecialiteViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SpecialiteViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SpecialiteViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SpecialiteViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Specialites, x => x.Code_SP) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Options for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Option> LookUpOptions {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SpecialiteViewModel x) => x.LookUpOptions,
                    getRepositoryFunc: x => x.Options);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Branches for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Branch> LookUpBranches {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SpecialiteViewModel x) => x.LookUpBranches,
                    getRepositoryFunc: x => x.Branches);
            }
        }


        /// <summary>
        /// The view model for the SpecialiteOptions detail collection.
        /// </summary>
        public CollectionViewModelBase<Option, Option, int, IgtscoUnitOfWork> SpecialiteOptionsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SpecialiteViewModel x) => x.SpecialiteOptionsDetails,
                    getRepositoryFunc: x => x.Options,
                    foreignKeyExpression: x => x.Specialite,
                    navigationExpression: x => x.Specialite1);
            }
        }
    }
}
