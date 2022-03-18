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
    /// Represents the Proce_verbal_delibation collection view model.
    /// </summary>
    public partial class Proce_verbal_delibationCollectionViewModel : CollectionViewModel<Proce_verbal_delibation, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Proce_verbal_delibationCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Proce_verbal_delibationCollectionViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Proce_verbal_delibationCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Proce_verbal_delibationCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Proce_verbal_delibationCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Proce_verbal_delibationCollectionViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Proce_verbal_delibation) {
        }
    }
}