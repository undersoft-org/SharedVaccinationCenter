﻿// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   server: Undersoft.SVC.Service.Application.Server
// ********************************************************

using Undersoft.SDK;
using Undersoft.SDK.Service;
using Undersoft.SDK.Service.Operation.Remote.Command.Validator;

namespace Undersoft.SVC.Service.Application.Server.Validators;

using Undersoft.SVC.Service.Contracts.Catalogs;

/// <summary>
/// The contact validator.
/// </summary>
public class OfficeValidator : RemoteCommandValidator<Office>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatientValidator"/> class.
    /// </summary>
    /// <param name="servicer">The servicer.</param>
    public OfficeValidator(IServicer servicer) : base(servicer)
    {
        ValidationScope(
            OperationKind.Any,
            () =>
            {
                ValidateRequired(p => p.Model.Name);
                ValidateRequired(p => p.Model.Number);
            }
        );

    }
}
