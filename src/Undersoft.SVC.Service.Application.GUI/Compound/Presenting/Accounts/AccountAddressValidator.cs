﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   library: Undersoft.SVC.Service.Application.GUI
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Application.GUI.View;

namespace Undersoft.SVC.Service.Application.GUI.Compound.Access;

using Undersoft.SVC.Service.Contracts.Accounts;

/// <summary>
/// The account validator.
/// </summary>
public class AccountAddressValidator : ViewValidator<AccountAddress>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountValidator"/> class.
    /// </summary>
    /// <param name="servicer">The servicer.</param>
    public AccountAddressValidator(IServicer servicer) : base(servicer)
    {
        ValidationScope(
            OperationType.Any,
            () =>
            {
                ValidateRequired(p => p.Model.Country);
                ValidateRequired(p => p.Model.City);
                ValidateRequired(p => p.Model.Postcode);
                ValidateRequired(p => p.Model.Street);
                ValidateRequired(p => p.Model.Building);
                ValidateRequired(p => p.Model.Apartment);
            }
        );
    }
}
