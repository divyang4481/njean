// <copyright file="ITemplateOrigin.cs" company="Liquid Software Development">
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

    #endregion

    /// <summary>
    /// Base interface that describes a template's origin.
    /// </summary>
    /// <author>
    /// <a href="mailto:george.labak@gmail.com">Labak</a>
    /// <a href="mailto:laodimos@gmail.com">Laodimos</a>
    /// <a href="mailto:diadistis@gmail.com">Diadistis</a>
    /// </author>
    public interface ITemplateOrigin
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is trusted.
        /// </summary>
        /// <value>
        ///    <c>true</c> if this instance is trusted; otherwise, <c>false</c>.
        /// </value>
        bool IsTrusted { get; set; }
    }
}
