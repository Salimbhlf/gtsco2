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
    /// Represents the single Proce_verbal_delibation object view model.
    /// </summary>
    public partial class Proce_verbal_delibationViewModel : SingleObjectViewModel<Proce_verbal_delibation, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Proce_verbal_delibationViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Proce_verbal_delibationViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Proce_verbal_delibationViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Proce_verbal_delibationViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Proce_verbal_delibationViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Proce_verbal_delibationViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Proce_verbal_delibation, x => x.ID_PV_Délibiration) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Decisions for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Decision> LookUpDecisions {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Proce_verbal_delibationViewModel x) => x.LookUpDecisions,
                    getRepositoryFunc: x => x.Decisions);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of PARTICIPEs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<PARTICIPE> LookUpPARTICIPEs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Proce_verbal_delibationViewModel x) => x.LookUpPARTICIPEs,
                    getRepositoryFunc: x => x.PARTICIPEs);
            }
        }


        /// <summary>
        /// The view model for the Proce_verbal_delibationDecisions detail collection.
        /// </summary>
        public CollectionViewModelBase<Decision, Decision, int, IgtscoUnitOfWork> Proce_verbal_delibationDecisionsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Proce_verbal_delibationViewModel x) => x.Proce_verbal_delibationDecisionsDetails,
                    getRepositoryFunc: x => x.Decisions,
                    foreignKeyExpression: x => x.ID_PV_Délibiration,
                    navigationExpression: x => x.Proce_verbal_delibation);
            }
        }

        /// <summary>
        /// The view model for the Proce_verbal_delibationPARTICIPEs detail collection.
        /// </summary>
        public CollectionViewModelBase<PARTICIPE, PARTICIPE, Tuple<int, int>, IgtscoUnitOfWork> Proce_verbal_delibationPARTICIPEsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Proce_verbal_delibationViewModel x) => x.Proce_verbal_delibationPARTICIPEsDetails,
                    getRepositoryFunc: x => x.PARTICIPEs,
                    foreignKeyExpression: x => x.ID_PV_Délibiration,
                    navigationExpression: x => x.Proce_verbal_delibation);
            }
        }
    }
}
