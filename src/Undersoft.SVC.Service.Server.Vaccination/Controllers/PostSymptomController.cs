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
    using Undersoft.SDK.Service.Server.Controller;
    using Undersoft.SVC.Service.Contracts.Vaccination;

    /// <summary>
    /// The contact controller.
    /// </summary>
    public class PostSymptomController
        : CqrsController<
            long,
            IEntryStore,
            IReportStore,
            Domain.Entities.Vaccination.PostSymptom,
            PostSymptom,
            ServiceManager
        >
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSymptomController"/> class.
        /// </summary>
        /// <param name="servicer">The servicer.</param>
        public PostSymptomController(IServicer servicer) : base(servicer) { }
    }
}