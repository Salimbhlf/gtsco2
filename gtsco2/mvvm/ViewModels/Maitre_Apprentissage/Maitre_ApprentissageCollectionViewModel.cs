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
    /// Represents the Maitre_Apprentissage collection view model.
    /// </summary>
    public partial class Maitre_ApprentissageCollectionViewModel : CollectionViewModel<Maitre_Apprentissage, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Maitre_ApprentissageCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Maitre_ApprentissageCollectionViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Maitre_ApprentissageCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Maitre_ApprentissageCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Maitre_ApprentissageCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Maitre_ApprentissageCollectionViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Maitre_Apprentissage) {
        }
    }
}