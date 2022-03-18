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
    /// Represents the Avenant_contrat_prorogation collection view model.
    /// </summary>
    public partial class Avenant_contrat_prorogationCollectionViewModel : CollectionViewModel<Avenant_contrat_prorogation, Tuple<string, int>, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Avenant_contrat_prorogationCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Avenant_contrat_prorogationCollectionViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Avenant_contrat_prorogationCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Avenant_contrat_prorogationCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Avenant_contrat_prorogationCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Avenant_contrat_prorogationCollectionViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Avenant_contrat_prorogation) {
        }
    }
}