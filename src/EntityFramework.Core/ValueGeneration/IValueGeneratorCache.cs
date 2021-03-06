// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Metadata;

namespace Microsoft.Data.Entity.ValueGeneration
{
    public interface IValueGeneratorCache
    {
        ValueGenerator GetOrAdd([NotNull] IProperty property, [NotNull] Func<IProperty, ValueGenerator> factory);
    }
}
