// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.SVC.Service.Application.Server.Controllers;

using Microsoft.AspNetCore.Authorization;
using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Server.Controller;
using Undersoft.SVC.Service.Clients.Abstractions;
using Undersoft.SVC.Service.Contracts.Vaccination;

[Authorize]
public class AppointmentController
    : RemoteDataController<long, IVaccinationStore, Appointment, Appointment, ServiceManager>
{
    public AppointmentController(IServicer servicer) : base(servicer) { }
}
