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
    /// Represents the single Transferer object view model.
    /// </summary>
    public partial class TransfererViewModel : SingleObjectViewModel<Transferer, Tuple<int, string>, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TransfererViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TransfererViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TransfererViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TransfererViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TransfererViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TransfererViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Transferers, x => x.num_stg) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Etablissements for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Etablissement> LookUpEtablissements {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TransfererViewModel x) => x.LookUpEtablissements,
                    getRepositoryFunc: x => x.Etablissements);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TransfererViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }

    }
}
