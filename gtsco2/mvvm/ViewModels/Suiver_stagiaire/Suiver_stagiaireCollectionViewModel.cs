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
    /// Represents the Suiver_stagiaire collection view model.
    /// </summary>
    public partial class Suiver_stagiaireCollectionViewModel : CollectionViewModel<Suiver_stagiaire, Tuple<string, int, int>, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Suiver_stagiaireCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Suiver_stagiaireCollectionViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Suiver_stagiaireCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Suiver_stagiaireCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Suiver_stagiaireCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Suiver_stagiaireCollectionViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Suiver_stagiaire) {
        }
    }
}