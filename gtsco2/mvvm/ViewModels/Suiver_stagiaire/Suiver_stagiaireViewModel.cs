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
    /// Represents the single Suiver_stagiaire object view model.
    /// </summary>
    public partial class Suiver_stagiaireViewModel : SingleObjectViewModel<Suiver_stagiaire, Tuple<string, int, int>, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Suiver_stagiaireViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Suiver_stagiaireViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Suiver_stagiaireViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Suiver_stagiaireViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Suiver_stagiaireViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Suiver_stagiaireViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Suiver_stagiaire, x => x.num_stg) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Enseignants for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Enseignant> LookUpEnseignants {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Suiver_stagiaireViewModel x) => x.LookUpEnseignants,
                    getRepositoryFunc: x => x.Enseignants);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Semestres for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Semestre> LookUpSemestres {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Suiver_stagiaireViewModel x) => x.LookUpSemestres,
                    getRepositoryFunc: x => x.Semestres);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Suiver_stagiaireViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }

    }
}
