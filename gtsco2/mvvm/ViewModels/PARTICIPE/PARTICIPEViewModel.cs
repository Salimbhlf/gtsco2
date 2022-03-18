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
    /// Represents the single PARTICIPE object view model.
    /// </summary>
    public partial class PARTICIPEViewModel : SingleObjectViewModel<PARTICIPE, Tuple<int, int>, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PARTICIPEViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PARTICIPEViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PARTICIPEViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PARTICIPEViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PARTICIPEViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PARTICIPEViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PARTICIPEs, x => x.Qualite) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Enseignants for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Enseignant> LookUpEnseignants {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PARTICIPEViewModel x) => x.LookUpEnseignants,
                    getRepositoryFunc: x => x.Enseignants);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Proce_verbal_delibation for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Proce_verbal_delibation> LookUpProce_verbal_delibation {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PARTICIPEViewModel x) => x.LookUpProce_verbal_delibation,
                    getRepositoryFunc: x => x.Proce_verbal_delibation);
            }
        }

    }
}
