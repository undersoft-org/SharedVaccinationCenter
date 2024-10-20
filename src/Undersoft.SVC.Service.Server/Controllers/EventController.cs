// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server.Controller;

namespace Undersoft.SVC.Service.Server.Controllers;

public class EventController : BusController<long, IEventStore, Event, Contracts.Event, ServiceManager>
{
    public EventController(IServicer servicer) : base(servicer) { }
}
