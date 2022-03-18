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
    /// Represents the single Module object view model.
    /// </summary>
    public partial class ModuleViewModel : SingleObjectViewModel<Module, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ModuleViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ModuleViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ModuleViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ModuleViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ModuleViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ModuleViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Modules, x => x.Designation_Module) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Evaluations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Evaluation> LookUpEvaluations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ModuleViewModel x) => x.LookUpEvaluations,
                    getRepositoryFunc: x => x.Evaluations);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Options for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Option> LookUpOptions {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ModuleViewModel x) => x.LookUpOptions,
                    getRepositoryFunc: x => x.Options);
            }
        }


        /// <summary>
        /// The view model for the ModuleEvaluations detail collection.
        /// </summary>
        public CollectionViewModelBase<Evaluation, Evaluation, Tuple<string, int, int, int>, IgtscoUnitOfWork> ModuleEvaluationsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ModuleViewModel x) => x.ModuleEvaluationsDetails,
                    getRepositoryFunc: x => x.Evaluations,
                    foreignKeyExpression: x => x.ID_Module,
                    navigationExpression: x => x.Module);
            }
        }
    }
}
