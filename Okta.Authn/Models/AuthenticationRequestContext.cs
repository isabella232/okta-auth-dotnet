﻿// <copyright file="AuthenticationRequestContext.cs" company="Okta, Inc">
// Copyright (c) 2018 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using Okta.Sdk.Abstractions;

namespace Okta.Authn.Models
{
    public class AuthenticationRequestContext : BaseResource
    {
        public string DeviceToken
        {
            get => GetStringProperty("deviceToken");
            set => this["deviceToken"] = value;
        }
    }
}
