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
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

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
        /// Loads a temlate from the specified string.
        /// </summary>
        /// <param name="templateContent">The string to be loaded.</param>
        /// <returns>The template.</returns>
        ITemplate Load(string templateContent);

        /// <summary>
        /// Loads a temlate from the specified TextReader.
        /// </summary>
        /// <param name="reader">The TextReader to be loaded.</param>
        /// <returns>The template.</returns>
        ITemplate Load(TextReader reader);

        /// <summary>
        /// Loads a temlate from the specified file.
        /// </summary>
        /// <param name="fileName">The file to be loaded.</param>
        /// <returns>The template.</returns>
        ITemplate LoadFromFile(string fileName);        
    }
}
