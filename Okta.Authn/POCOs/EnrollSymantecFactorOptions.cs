﻿// <copyright file="EnrollSymantecFactorOptions.cs" company="Okta, Inc">
// Copyright (c) 2018 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using Okta.Auth.Sdk.Models;

namespace Okta.Auth.Sdk.POCOs
{
    public class EnrollSymantecFactorOptions
    {
        public string StateToken { get; set; }

        public string CredentialId { get; set; }

        public string Provider { get; set; } = OktaDefaults.SymantecProvider;

        public string PassCode { get; set; }

        public string NextPassCode { get; set; }
    }
}
