﻿// <copyright file="ITemplate.cs" company="Liquid Software Development">
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
    using System.IO;

    #endregion

    /// <summary>
    /// Base interface that describes the methods templates need to implement. 
    /// </summary>
    /// <author>
    /// <a href="mailto:diadistis@gmail.com">Diadistis</a>
    /// <a href="mailto:labak.george@gmail.com">labak</a>
    /// </author>
    public interface ITemplate
    {
        /// <summary>
        /// Gets or sets the template origin.
        /// </summary>
        /// <value>The template origin.</value>
        ITemplateOrigin TemplateOrigin { get; set; }

        /// <summary>        
        /// Renders the template using the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>The rendered template.</returns>
        string Render(ITemplateContext context);

        /// <summary>
        /// Renders the template using the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="writer">
        /// A <see cref="T:System.IO.TextWriter"/> to be used for output.
        /// </param>
        void Render(ITemplateContext context, TextWriter writer);
    }
}