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
    /// Represents the Promoes collection view model.
    /// </summary>
    public partial class PromoCollectionViewModel : CollectionViewModel<Promo, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PromoCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PromoCollectionViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PromoCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PromoCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PromoCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PromoCollectionViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Promoes) {
        }
    }
}