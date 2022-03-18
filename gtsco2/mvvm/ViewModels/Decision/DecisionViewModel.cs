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
    /// Represents the single Decision object view model.
    /// </summary>
    public partial class DecisionViewModel : SingleObjectViewModel<Decision, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of DecisionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static DecisionViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new DecisionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the DecisionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DecisionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected DecisionViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Decisions, x => x.Type_Decision) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Proce_verbal_delibation for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Proce_verbal_delibation> LookUpProce_verbal_delibation {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (DecisionViewModel x) => x.LookUpProce_verbal_delibation,
                    getRepositoryFunc: x => x.Proce_verbal_delibation);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Promoes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Promo> LookUpPromoes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (DecisionViewModel x) => x.LookUpPromoes,
                    getRepositoryFunc: x => x.Promoes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Semestres for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Semestre> LookUpSemestres {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (DecisionViewModel x) => x.LookUpSemestres,
                    getRepositoryFunc: x => x.Semestres);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (DecisionViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }

    }
}
