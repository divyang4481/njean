﻿// <copyright file="ITemplateContext.cs" company="Liquid Software Development">
// Copyright 2008-2009 Liquid Software Development - http://www.liquidsd.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

namespace Lsd.NJean
{
    #region Imports

    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    #endregion

    /// <summary>
    /// Base interface that describes a template's context.
    /// </summary>
    /// <author>
    /// <a href="mailto:diadistis@gmail.com">Diadistis</a>
    /// <a href="mailto:laodimos@gmail.com">Laodimos</a>
    /// </author>
    [SuppressMessage
        ("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", 
        Justification = "Context is a much better suffix than Dictionary.")]
    public interface ITemplateContext : IDictionary<string, object>
    {
    }
}