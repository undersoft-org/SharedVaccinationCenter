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

namespace Undersoft.SVC.Service.Application.GUI.Compound.Presenting.NavMenu.Validators;

using Undersoft.SVC.Service.Application.ViewModels.Vaccination;

/// <summary>
/// The group validator.
/// </summary>
public class PostSymptomValidator : ViewValidator<PostSymptom>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OfficeValidator"/> class.
    /// </summary>
    /// <param name="servicer">The servicer.</param>
    public PostSymptomValidator(IServicer servicer) : base(servicer)
    {
        ValidationScope(
            OperationKind.Any,
            () =>
            {
                ValidateRequired(p => p.Model.Personal!.FirstName);
            }
        );
    }
}
