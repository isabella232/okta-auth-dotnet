﻿// <copyright file="ChangePasswordOptions.cs" company="Okta, Inc">
// Copyright (c) 2018 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

namespace Okta.Auth.Sdk.POCOs
{
    public class ChangePasswordOptions
    {
        public string StateToken { get; set; }

        public string OldPassword { get; set; }

        public string NewPassword { get; set; }
    }
}
