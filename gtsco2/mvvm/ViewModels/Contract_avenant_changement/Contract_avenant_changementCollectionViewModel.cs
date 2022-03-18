using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using gtsco2.mvvm.gtscoDataModel;
using gtsco2.mvvm.Common;
using gtsco2.basededonne;

namespace gtsco2.mvvm.ViewModels {

    /// <summary>
    /// Represents the Contract_avenant_changement collection view model.
    /// </summary>
    public partial class Contract_avenant_changementCollectionViewModel : CollectionViewModel<Contract_avenant_changement, Tuple<int, string>, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Contract_avenant_changementCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Contract_avenant_changementCollectionViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Contract_avenant_changementCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Contract_avenant_changementCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Contract_avenant_changementCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Contract_avenant_changementCollectionViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Contract_avenant_changement) {
        }
    }
}