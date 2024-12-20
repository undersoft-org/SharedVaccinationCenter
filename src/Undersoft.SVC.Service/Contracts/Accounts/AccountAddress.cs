﻿// *************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SVC.Service
// *************************************************

using Undersoft.SDK.Service.Data.Contract;
using Undersoft.SDK.Service.Operation;

namespace Undersoft.SVC.Service.Contracts.Accounts
{
    [Validator("AccountAddressValidator", typeof(AccountAddress))]
    public class AccountAddress : SDK.Service.Access.Identity.Address, IContract
    {
        public virtual long? AccountId { get; set; }
    }
}