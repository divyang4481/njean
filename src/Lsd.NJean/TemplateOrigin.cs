﻿// <copyright file="TemplateOrigin.cs" company="Liquid Software Development">
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
    /// The origin of the template
    /// </summary>
    /// <author>
    /// <a href="mailto:labak.george@gmail.com">labak</a>
    /// </author>
    public class TemplateOrigin : ITemplateOrigin
    {
        #region ITemplateOrigin Members

        private bool isTrusted;

        private ITemplateProvider templateProvider;

        private string templateSource;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is trusted.
        /// </summary>
        /// <value>
        ///    <c>true</c> if this instance is trusted; otherwise, <c>false</c>.
        /// </value>
        public bool IsTrusted
        {
            get
            {
                return this.isTrusted;
            }

            set
            {
                this.isTrusted = value;
            }
        }

        /// <summary>
        /// Gets or sets the template provider.
        /// </summary>
        /// <value>The template provider.</value>
        public ITemplateProvider TemplateProvider
        {
            get
            {
                return this.templateProvider;
            }

            set
            {
                this.templateProvider = value;
            }
        }

        /// <summary>
        /// Gets or sets the template source.
        /// </summary>
        /// <value>The template source.</value>
        public string TemplateSource
        {
            get
            {
                return this.templateSource;
            }

            set
            {
                this.templateSource = value;
            }
        }

        #endregion
    }
}
