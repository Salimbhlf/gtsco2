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
    /// Represents the single Contract_avenant_changement object view model.
    /// </summary>
    public partial class Contract_avenant_changementViewModel : SingleObjectViewModel<Contract_avenant_changement, Tuple<int, string>, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Contract_avenant_changementViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Contract_avenant_changementViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Contract_avenant_changementViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Contract_avenant_changementViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Contract_avenant_changementViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Contract_avenant_changementViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Contract_avenant_changement, x => x.num_stg) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Employeurs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employeur> LookUpEmployeurs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Contract_avenant_changementViewModel x) => x.LookUpEmployeurs,
                    getRepositoryFunc: x => x.Employeurs);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Contract_avenant_changementViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }

    }
}
