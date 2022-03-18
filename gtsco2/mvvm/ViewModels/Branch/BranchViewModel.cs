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
    /// Represents the single Branch object view model.
    /// </summary>
    public partial class BranchViewModel : SingleObjectViewModel<Branch, string, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BranchViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BranchViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BranchViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BranchViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BranchViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BranchViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Branches, x => x.Code_Branche) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Specialites for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Specialite> LookUpSpecialites {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (BranchViewModel x) => x.LookUpSpecialites,
                    getRepositoryFunc: x => x.Specialites);
            }
        }


        /// <summary>
        /// The view model for the BranchSpecialites detail collection.
        /// </summary>
        public CollectionViewModelBase<Specialite, Specialite, int, IgtscoUnitOfWork> BranchSpecialitesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (BranchViewModel x) => x.BranchSpecialitesDetails,
                    getRepositoryFunc: x => x.Specialites,
                    foreignKeyExpression: x => x.ID_Branche,
                    navigationExpression: x => x.Branch);
            }
        }
    }
}
