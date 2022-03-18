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
    /// Represents the single Willaya object view model.
    /// </summary>
    public partial class WillayaViewModel : SingleObjectViewModel<Willaya, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of WillayaViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static WillayaViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new WillayaViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the WillayaViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the WillayaViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected WillayaViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Willayas, x => x.Wilaya_name__ar) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Communes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Commune> LookUpCommunes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (WillayaViewModel x) => x.LookUpCommunes,
                    getRepositoryFunc: x => x.Communes);
            }
        }


        /// <summary>
        /// The view model for the WillayaCommunes detail collection.
        /// </summary>
        public CollectionViewModelBase<Commune, Commune, int, IgtscoUnitOfWork> WillayaCommunesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (WillayaViewModel x) => x.WillayaCommunesDetails,
                    getRepositoryFunc: x => x.Communes,
                    foreignKeyExpression: x => x.Code_Willaya,
                    navigationExpression: x => x.Willaya);
            }
        }
    }
}
