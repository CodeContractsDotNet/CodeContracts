// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace Microsoft.Research.CodeAnalysis.Caching.Models
{
    public class Metadata
    {
        public string Key { get; set; }
        public byte[] Value { get; set; }
    }
}
