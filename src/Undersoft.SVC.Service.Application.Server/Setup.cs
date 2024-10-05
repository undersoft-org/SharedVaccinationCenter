// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK.Service.Application.Server;
using Undersoft.SDK.Service.Application.Server.Hosting;
using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server;

namespace Undersoft.SVC.Service.Application.Server;

using Undersoft.SVC.Service.Clients.Abstractions;

public class Setup
{
    public void ConfigureServices(IServiceCollection srvc)
    {
        srvc.AddApplicationServerSetup()
            .ConfigureApplicationServer()
            .AddDataServer<ICenterStore>(DataServerTypes.All)
            .AddDataServer<IEventStore>(DataServerTypes.All)
            .AddDataServer<IAccountStore>(DataServerTypes.All);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseApplicationServerSetup(env)
            .UseServiceApplication()
            .UseInternalProvider()
            .UseDataMigrations()
            .UseServiceClients();
    }
}
