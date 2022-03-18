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
    /// Represents the single Avenant_contrat_prorogation object view model.
    /// </summary>
    public partial class Avenant_contrat_prorogationViewModel : SingleObjectViewModel<Avenant_contrat_prorogation, Tuple<string, int>, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Avenant_contrat_prorogationViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Avenant_contrat_prorogationViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Avenant_contrat_prorogationViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Avenant_contrat_prorogationViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Avenant_contrat_prorogationViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Avenant_contrat_prorogationViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Avenant_contrat_prorogation, x => x.Num_stg) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Employeurs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employeur> LookUpEmployeurs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Avenant_contrat_prorogationViewModel x) => x.LookUpEmployeurs,
                    getRepositoryFunc: x => x.Employeurs);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Avenant_contrat_prorogationViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }

    }
}
