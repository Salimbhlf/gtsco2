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
    /// Represents the single Etablissement object view model.
    /// </summary>
    public partial class EtablissementViewModel : SingleObjectViewModel<Etablissement, int, IgtscoUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EtablissementViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EtablissementViewModel Create(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new EtablissementViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the EtablissementViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EtablissementViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EtablissementViewModel(IUnitOfWorkFactory<IgtscoUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Etablissements, x => x.Nom_ETAB) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Stagiairs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Stagiair> LookUpStagiairs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EtablissementViewModel x) => x.LookUpStagiairs,
                    getRepositoryFunc: x => x.Stagiairs);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Code_Postal for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Code_Postal> LookUpCode_Postal {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EtablissementViewModel x) => x.LookUpCode_Postal,
                    getRepositoryFunc: x => x.Code_Postal);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Transferers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Transferer> LookUpTransferers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EtablissementViewModel x) => x.LookUpTransferers,
                    getRepositoryFunc: x => x.Transferers);
            }
        }


        /// <summary>
        /// The view model for the EtablissementStagiairs detail collection.
        /// </summary>
        public CollectionViewModelBase<Stagiair, Stagiair, string, IgtscoUnitOfWork> EtablissementStagiairsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EtablissementViewModel x) => x.EtablissementStagiairsDetails,
                    getRepositoryFunc: x => x.Stagiairs,
                    foreignKeyExpression: x => x.ID_ETAB,
                    navigationExpression: x => x.Etablissement);
            }
        }

        /// <summary>
        /// The view model for the EtablissementTransferers detail collection.
        /// </summary>
        public CollectionViewModelBase<Transferer, Transferer, Tuple<int, string>, IgtscoUnitOfWork> EtablissementTransferersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EtablissementViewModel x) => x.EtablissementTransferersDetails,
                    getRepositoryFunc: x => x.Transferers,
                    foreignKeyExpression: x => x.ID_etb,
                    navigationExpression: x => x.Etablissement);
            }
        }
    }
}
