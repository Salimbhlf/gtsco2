using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using gtsco2.mvvm.user.gtscoDataModel;

namespace gtsco2.mvvm.user.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the gtsco data model.
    /// </summary>
    public partial class gtscoViewModel : DocumentsViewModel<gtscoModuleDescription, IgtscoUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of gtscoViewModel as a POCO view model.
        /// </summary>
        public static gtscoViewModel Create() {
            return ViewModelSource.Create(() => new gtscoViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the gtscoViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the gtscoViewModel type without the POCO proxy factory.
        /// </summary>
        protected gtscoViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override gtscoModuleDescription[] CreateModules() {
			return new gtscoModuleDescription[] {
                new gtscoModuleDescription( "Users", "UserCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Users)),
			};
        }
                		protected override void OnActiveModuleChanged(gtscoModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class gtscoModuleDescription : ModuleDescription<gtscoModuleDescription> {
        public gtscoModuleDescription(string title, string documentType, string group, Func<gtscoModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}