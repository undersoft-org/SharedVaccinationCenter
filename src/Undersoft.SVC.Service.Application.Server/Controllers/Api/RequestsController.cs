﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************


using Undersoft.SDK.Service.Data.Store;

namespace Undersoft.SVC.Service.Application.Server.Controllers.Api;

using Microsoft.AspNetCore.Mvc;
using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Server.Controller.Api;
using Undersoft.SVC.Service.Clients.Abstractions;
using Undersoft.SVC.Service.Contracts.Inventory;

/// <summary>
/// The contact controller.
/// </summary>
[Route($"api/data/Request")]
public class RequestsController
    : ApiDataRemoteController<long, IInventoryStore, Request, Request, ServiceManager>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatientNodeController"/> class.
    /// </summary>
    /// <param name="servicer">The servicer.</param>
    public RequestsController(IServicer servicer) : base(servicer) { }
}
