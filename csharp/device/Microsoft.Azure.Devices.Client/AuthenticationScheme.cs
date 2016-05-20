﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Devices.Client
{
    /// <summary>
    /// Specifies the Authentication Scheme used by Device Client
    /// </summary>
    public enum AuthenticationScheme
    {
        // Shared Access Key
        SharedAccessKey = 0,
        // Shared Access Signature
        SharedAccessSignature = 1,
        // X509 Certificate
        X509 = 2
    }
}