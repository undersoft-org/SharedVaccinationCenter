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

namespace Undersoft.SVC.Service.Server.Vaccination.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Undersoft.SDK.Service.Server.Controller;
    using Undersoft.SVC.Service.Contracts.Vaccination;

    /// <summary>
    /// The contact controller.
    /// </summary>
    [Authorize]
    public class AppointmentController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Vaccination.Appointment,
            Appointment,
            ServiceManager
        >
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PatientNodeController"/> class.
        /// </summary>
        /// <param name="servicer">The servicer.</param>
        public AppointmentController(IServicer servicer) : base(servicer) { }
    }
}