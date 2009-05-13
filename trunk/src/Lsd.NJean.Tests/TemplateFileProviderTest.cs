// <copyright file="TemplateFileProviderTest.cs" company="Liquid Software Development">
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

namespace Lsd.NJean.Tests
{
    #region Imports

    using System;
    using System.IO;
    using NUnit.Framework;
    
    #endregion

    /// <summary>
    /// Summary description for TemplateFileProviderTest
    /// </summary>
    [TestFixture]
    public class FileTemplateProviderTest
    {
        private ITemplateProvider GetFileTemplateProvider()
        {
            return new FileTemplateProvider();
        }

        [Test]
        [ExpectedException(typeof(FileNotFoundException))]
        public void LoadNonExistingTemplate()
        {
            // Arrange
            ITemplate template;
            ITemplateProvider provider = this.GetFileTemplateProvider();

            // Act & Assert
            template = provider.Load("unknown");
        }

        [Test]
        public void TryLoadNonExistingTemplate()
        {
            // Arrange
            ITemplate template;
            ITemplateProvider provider = this.GetFileTemplateProvider();
            
            // Act
            bool result = provider.TryLoad("unknown", out template);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void LoadTemplate()
        {
            // Arrange
            ITemplate template;
            ITemplateProvider provider = this.GetFileTemplateProvider();

            // Act
            template = provider.Load("files/dummy.tpl");

            // Assert
            Assert.AreEqual(((Template)template).TemplateContent, "test");
        }

        [Test]
        public void TryLoadTemplate()
        {
            // Arrange
            ITemplate template;
            ITemplateProvider provider = this.GetFileTemplateProvider();

            // Act
            bool result = provider.TryLoad("files/dummy.tpl", out template);

            // Assert
            Assert.AreEqual(((Template)template).TemplateContent, "test");
            Assert.IsTrue(result);
        }

        public void TemplateExistsFalse()
        {
            // Arrange
            ITemplateProvider provider = this.GetFileTemplateProvider();

            // Act
            bool result = provider.Exists("unknown");

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void TemplateExistsTrue()
        {
            // Arrange
            ITemplateProvider provider = this.GetFileTemplateProvider();
            
            // Act
            bool result = provider.Exists("files/dummy.tpl");

            // Assert
            Assert.IsTrue(result);            
        }
    }
}
