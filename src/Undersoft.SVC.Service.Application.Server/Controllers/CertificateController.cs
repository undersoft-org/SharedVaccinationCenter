// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

namespace Undersoft.SVC.Service.Application.Server.Controllers;

using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Server.Controller;
using Undersoft.SVC.Service.Clients.Abstractions;
using Undersoft.SVC.Service.Contracts.Vaccination;

public class CertificateController
    : RemoteDataController<long, IVaccinationStore, Certificate, Certificate, ServiceManager>
{
    public CertificateController(IServicer servicer) : base(servicer) { }
}
