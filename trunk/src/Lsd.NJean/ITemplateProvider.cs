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
    /// Base interface that describes a template provider. The provider must 
    /// extend this interface to have access to a variety of template sources.
    /// </summary>
    /// <author>
    /// <a href="mailto:george.labak@gmail.com">Labak</a>
    /// <a href="mailto:diadistis@gmail.com">Diadistis</a>
    /// <a href="mailto:laodimos@gmail.com">Laodimos</a>
    /// </author>
    public interface ITemplateProvider
    {
        /// <summary>
        /// Loads a template.
        /// </summary>
        /// <param name="templateName">The name of the template.</param>
        /// <returns>The template.</returns>
        Template Load(string templateName);

        /// <summary>
        /// Tries to a template from the specified source.
        /// </summary>
        /// <param name="templateName">The name of the template.</param>
        /// <param name="loadedTemplate">
        /// When this method returns, if the there was no error, contains
        /// the loaded template. If there was a problem loading the template
        /// it contains null.
        /// </param>
        /// <returns>
        ///     <c>true</c> if the template is loaded without errors,
        ///     <c>false</c> otherwise
        /// </returns>
        bool TryLoad(string templateName, out Template loadedTemplate);

        /// <summary>
        /// Checks if the specified source exists.
        /// </summary>
        /// <param name="templateName">The name of the template.</param>
        /// <returns>
        ///     <c>true</c> if the source exists, <c>false</c> otherwise.
        /// </returns>
        bool Exists(string templateName);
    }
}
