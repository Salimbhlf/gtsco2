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
    /// Represents the single Absence object view model.
    /// </summary>
    public partial class AbsenceViewModel : SingleObjectViewModel<Absence, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AbsenceViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AbsenceViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AbsenceViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AbsenceViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AbsenceViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AbsenceViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Absences, x => x.Justif_ABS) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of annee_scolaire for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<annee_scolaire> LookUpannee_scolaire {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AbsenceViewModel x) => x.LookUpannee_scolaire,
                    getRepositoryFunc: x => x.annee_scolaire);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Semestres for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Semestre> LookUpSemestres {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AbsenceViewModel x) => x.LookUpSemestres,
                    getRepositoryFunc: x => x.Semestres);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AbsenceViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }

    }
}
