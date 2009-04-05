// <copyright file="ITemplateProvider.cs" company="Liquid Software Development">
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
    /// Base interface that describes template provider.
    /// </summary>
    /// <author>
    /// <a href="mailto:george.labak@gmail.com">Labak</a>
    /// </author>
    public interface ITemplateProvider
    {
        /// <summary>
        /// Gets the template source.
        /// </summary>
        /// <value>The template source.</value>
        ITemplateSource TemplateSource { get; }

        /// <summary>
        /// Loads a template from the specified source.
        /// </summary>
        /// <param name="templateSource">The source of the template.</param>
        /// <returns>The template.</returns>
        ITemplate Load(string templateSource);

        /// <summary>
        /// Tries to a template from the specified source.
        /// </summary>
        /// <param name="templateSource">The source of the template.</param>
        /// <param name="loadedTemplate">The template to be loaded.</param>
        /// <returns><c>true</c> if the template is loaded without exceptions, <c>true</c> otherwise</returns>
        bool TryLoad(string templateSource, out ITemplate loadedTemplate);

        /// <summary>
        /// Checks if the specified source exists.
        /// </summary>
        /// <param name="templateSource">The template source.</param>
        /// <returns><c>true</c> if the source exists, <c>true</c> otherwise.</returns>
        bool Exists(string templateSource);

        /// <summary>
        /// Determines whether the specified template source is trusted.
        /// </summary>
        /// <param name="templateSource">The template source.</param>
        /// <returns>
        ///    <c>true</c> if the specified template source is trusted; otherwise, <c>false</c>.
        /// </returns>
        bool IsTrusted(string templateSource);
    }
}
