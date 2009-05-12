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
    public class TemplateFileProviderTest
    {
        private TemplateFileProvider fileProvider = new TemplateFileProvider();
        private Template testTemplate = new Template();

        [Test]
        [ExpectedException(typeof(FileNotFoundException))]
        public void LoadNonExistingTemplate()
        {
            this.fileProvider.Load("unknown");
        }

        [Test]
        public void TryLoadNonExistingTemplate()
        {
            Assert.IsFalse(this.fileProvider.TryLoad("unknown", out this.testTemplate));            
        }

        [Test]
        public void LoadTemplate()
        {
            this.testTemplate = this.fileProvider.Load("files/dummy.tpl");
            Assert.AreEqual(this.testTemplate.TemplateContent, "test");
        }

        [Test]
        public void TryLoadTemplate()
        {
            this.fileProvider.TryLoad("files/dummy.tpl", out this.testTemplate);
            Assert.AreEqual(this.testTemplate.TemplateContent, "test");
        }

        [Test]
        public void TemplateExists()
        {
            Assert.IsTrue(this.fileProvider.Exists("files/dummy.tpl"));
            Assert.IsFalse(this.fileProvider.Exists("unknown"));
        }
    }
}
