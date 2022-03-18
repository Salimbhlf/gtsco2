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
    /// Represents the PARTICIPEs collection view model.
    /// </summary>
    public partial class PARTICIPECollectionViewModel : CollectionViewModel<PARTICIPE, Tuple<int, int>, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PARTICIPECollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PARTICIPECollectionViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PARTICIPECollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PARTICIPECollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PARTICIPECollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PARTICIPECollectionViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PARTICIPEs) {
        }
    }
}