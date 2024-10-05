// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License.
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Server
// ********************************************************

using Undersoft.SDK.Service.Data.Store;
using Undersoft.SDK.Service.Server;
using Undersoft.SDK.Service.Server.Hosting;

namespace Undersoft.SVC.Service.Server;

using Undersoft.SVC.Service.Contracts;
using Undersoft.SVC.Service.Infrastructure.Stores;

public class Setup
{  
    public void ConfigureServices(IServiceCollection srvc)
    {
        srvc.AddServerSetup()
            .ConfigureServer()
            .AddAccessServer<AccountStore, Account>()
            .AddDataServer<IEntityStore>()
            .AddDataServer<IEventStore>()
            .AddDataServer<IAccountStore>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseServerSetup(env)
            .UseServiceServer()
            .UseInternalProvider()
            .UseDataMigrations()
            .UseServiceClients();
    }
}
