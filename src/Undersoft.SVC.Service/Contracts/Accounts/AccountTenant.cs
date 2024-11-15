﻿using Undersoft.SDK.Service.Access.MultiTenancy;
using Undersoft.SDK.Service.Data.Contract;
using Undersoft.SDK.Service.Operation;

namespace Undersoft.SVC.Service.Contracts.Accounts;

[Validator("AccountTenantValidator", typeof(AccountTenant))]
public class AccountTenant : Tenant, IContract
{
}
