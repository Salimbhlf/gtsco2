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
    /// Represents the single Evaluation object view model.
    /// </summary>
    public partial class EvaluationViewModel : SingleObjectViewModel<Evaluation, Tuple<string, int, int, int>, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EvaluationViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EvaluationViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new EvaluationViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the EvaluationViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EvaluationViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EvaluationViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Evaluations, x => x.Num_STG) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of annee_scolaire for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<annee_scolaire> LookUpannee_scolaire {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EvaluationViewModel x) => x.LookUpannee_scolaire,
                    getRepositoryFunc: x => x.annee_scolaire);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Enseignants for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Enseignant> LookUpEnseignants {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EvaluationViewModel x) => x.LookUpEnseignants,
                    getRepositoryFunc: x => x.Enseignants);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Modules for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Module> LookUpModules {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EvaluationViewModel x) => x.LookUpModules,
                    getRepositoryFunc: x => x.Modules);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Semestres for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Semestre> LookUpSemestres {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EvaluationViewModel x) => x.LookUpSemestres,
                    getRepositoryFunc: x => x.Semestres);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EvaluationViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }

    }
}
