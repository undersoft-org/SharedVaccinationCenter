// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************


// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.SVC.Service.Server.Catalogs.Controllers
{
    using Undersoft.SDK.Service.Server.Controller;
    using Undersoft.SVC.Service.Contracts.Catalogs;

    /// <summary>
    /// The contact controller.
    /// </summary>
    public class VaccineController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Catalogs.Vaccine,
            Vaccine,
            ServiceManager
        >
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientNodeController"/> class.
        /// </summary>
        /// <param name="servicer">The servicer.</param>
        public VaccineController(IServicer servicer) : base(servicer) { }
    }
}