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

using Undersoft.SDK.Service;

namespace Undersoft.SVC.Service.Application.Server.Controllers;

using Undersoft.SDK.Service.Server.Controller;
using Undersoft.SVC.Service.Clients.Abstractions;
using Undersoft.SVC.Service.Contracts.Inventory;

public class TrafficController
    : RemoteDataController<
        long,
        IInventoryStore,
        Traffic,
        Traffic,
        ServiceManager
    >
{
    public TrafficController(IServicer servicer) : base(servicer) { }
}
