using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using gtsco2.basededonne;
using System;
using System.Collections;
using System.Linq;

namespace gtsco2.mvvm.gtscoDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IgtscoUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IgtscoUnitOfWork>(() => new gtscoUnitOfWork(() => new gtsco()));
        }
    }
}