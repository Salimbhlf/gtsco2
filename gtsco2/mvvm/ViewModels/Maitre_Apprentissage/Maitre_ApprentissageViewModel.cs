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
    /// Represents the single Maitre_Apprentissage object view model.
    /// </summary>
    public partial class Maitre_ApprentissageViewModel : SingleObjectViewModel<Maitre_Apprentissage, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Maitre_ApprentissageViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Maitre_ApprentissageViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Maitre_ApprentissageViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Maitre_ApprentissageViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Maitre_ApprentissageViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Maitre_ApprentissageViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Maitre_Apprentissage, x => x.Nom_Maitre_Apprentissage) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Maitre_ApprentissageViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Communes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Commune> LookUpCommunes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Maitre_ApprentissageViewModel x) => x.LookUpCommunes,
                    getRepositoryFunc: x => x.Communes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Employeurs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employeur> LookUpEmployeurs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Maitre_ApprentissageViewModel x) => x.LookUpEmployeurs,
                    getRepositoryFunc: x => x.Employeurs);
            }
        }


        /// <summary>
        /// The view model for the Maitre_ApprentissageStagiairs detail collection.
        /// </summary>
        public CollectionViewModelBase<Stagiair, Stagiair, string, IgtscoUnitOfWork> Maitre_ApprentissageStagiairsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (Maitre_ApprentissageViewModel x) => x.Maitre_ApprentissageStagiairsDetails,
                    getRepositoryFunc: x => x.Stagiairs,
                    foreignKeyExpression: x => x.ID_Maitre_Apprentissage,
                    navigationExpression: x => x.Maitre_Apprentissage);
            }
        }
    }
}
