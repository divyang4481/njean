// <copyright file="TemplateFileProvider.cs" company="Liquid Software Development">
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
    #region imports
    using System;
    using System.IO;
    using System.Security.AccessControl;
    #endregion
    /// <summary>
    /// An implementation of the ITemplateProvider interface.
    /// </summary>
    /// <author>
    /// <a href="mailto:labak.george@gmail.com">labak</a>
    /// </author> 
    public class TemplateFileProvider : ITemplateProvider
    {
        #region ITemplateProvider Members

        /// <summary>
        /// Loads the template from the specified path.
        /// </summary>
        /// <param name="templatePath">The template path.</param>
        /// <returns>A template</returns>
        public ITemplate Load(string templatePath)
        {
            Template template = new Template();
            template.TemplateContent = File.OpenText(templatePath).ReadToEnd();
            template.TemplateOrigin.TemplateSource = templatePath;
            template.TemplateOrigin.TemplateProvider = this;
            template.TemplateOrigin.IsTrusted = true;
            return template;
        }

        /// <summary>
        /// Tries to load a Template.
        /// </summary>
        /// <param name="templatePath">The template path.</param>
        /// <param name="loadedTemplate">The loaded template.</param>
        /// <returns>True on a successfull load. False otherwise.</returns>
        public bool TryLoad(string templatePath, out ITemplate loadedTemplate)
        {
            if (File.Exists(templatePath))
            {
                loadedTemplate = this.Load(templatePath);
                return true;
            }
            loadedTemplate = null;
            return false;
        }

        /// <summary>
        /// Checks if the specified template exists.
        /// </summary>
        /// <param name="templatePath">The template path.</param>
        /// <returns><c>true</c> if the template exists; <c>false</c> otherwise.</returns>
        public bool Exists(string templatePath)
        {
            return File.Exists(templatePath);
        }
        
        #endregion
    }
}
