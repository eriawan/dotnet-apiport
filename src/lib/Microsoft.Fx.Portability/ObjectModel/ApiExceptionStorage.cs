﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace Microsoft.Fx.Portability.ObjectModel
{
    public class ApiExceptionStorage
    {
        public string DocId { get; set; }

        public IEnumerable<ApiException> Exceptions { get; set; }
    }
}
