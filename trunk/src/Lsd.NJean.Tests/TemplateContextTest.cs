// <copyright file="TemplateContextTest.cs" company="Liquid Software Development">
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
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using NUnit.Framework;
   
    #endregion

    /// <summary>
    /// Template context tests
    /// </summary>
    [TestFixture]
    public class TemplateContextTest
    {
        /// <summary>
        /// Constructors the with dictionary copies dictionary entries.
        /// </summary>
        [Test]
        public void ConstructorWithDictionaryCopiesDictionaryEntries()
        {
            // Arrange
            IDictionary<string, object> sourceDictionary =
                new Dictionary<string, object>();
            
            sourceDictionary.Add("key1", "value1");
            sourceDictionary.Add("key2", 2);            
            
            // Act
            TemplateContext templateContext = 
                new TemplateContext(sourceDictionary);

            // Assert
            Assert.IsTrue(templateContext.ContainsKey("key1"));
            Assert.IsTrue(templateContext.ContainsKey("key2"));
            Assert.AreEqual("value1", templateContext["key1"]);
            Assert.AreEqual(2, templateContext["key2"]);
        }

        /// <summary>
        /// Constructors the with template context copies context entries.
        /// </summary>
        [Test]
        public void ConstructorWithTemplateContextCopiesContextEntries()
        {
            // Arrange
            TemplateContext sourceTemplateContext =
                new TemplateContext();

            sourceTemplateContext.Add("key1", "value1");
            sourceTemplateContext.Add("key2", 2);

            // Act
            TemplateContext templateContext =
                new TemplateContext(sourceTemplateContext);

            // Assert
            Assert.IsTrue(templateContext.ContainsKey("key1"));
            Assert.IsTrue(templateContext.ContainsKey("key2"));
            Assert.AreEqual("value1", templateContext["key1"]);
            Assert.AreEqual(2, templateContext["key2"]);
        }

        /// <summary>
        /// Checks the read only dictionary.
        /// </summary>
        [Test]
        [ExpectedException(typeof(NotSupportedException))]
        public void CheckReadOnlyDictionary()
        {
            // Arrange
            IDictionary<string, object> sourceDictionary =
                new Dictionary<string, object>();

            sourceDictionary.Add("key1", "value1");
            sourceDictionary.Add("key2", 2);

            IDictionary<string, object> readOnlyDictionary =
                new ReadOnlyDictionary<string, object>(sourceDictionary);

            // Act & Assert
            readOnlyDictionary.Add("key3", "value3");
        }

        /// <summary>
        /// Constructors the with read only dictionary is writable.
        /// </summary>
        [Test]
        public void ConstructorWithReadOnlyDictionaryIsWritable()
        {
            // Arrange
            IDictionary<string, object> sourceDictionary =
                new Dictionary<string, object>();

            sourceDictionary.Add("key1", "value1");
            sourceDictionary.Add("key2", 2);

            IDictionary<string, object> readOnlyDictionary =
                new ReadOnlyDictionary<string, object>(sourceDictionary);

            TemplateContext templateContext =
                new TemplateContext(readOnlyDictionary);

            // Act & Assert
            templateContext.Add("key3", "value3");
        }
    }
}
