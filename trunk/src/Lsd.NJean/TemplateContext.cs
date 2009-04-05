// <copyright file="TemplateContext.cs" company="Liquid Software Development">
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
    
    #endregion

    [SuppressMessage
        ("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix",
        Justification = "Context is a much better suffix than Dictionary.")]
    public partial class TemplateContext : ITemplateContext
    {
        #region Fields

        private readonly IDictionary<string, object> innerDictionary;

        #endregion

        #region Constructors

        public TemplateContext()
        {
            this.innerDictionary =
                new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        }

        public TemplateContext(TemplateContext context)
        {
            this.innerDictionary = context.innerDictionary;
        }

        public TemplateContext(IDictionary<string, object> context)
        {
            this.innerDictionary = context;
        }

        #endregion
    }

    public partial class TemplateContext
    {
        #region IDictionary<string,object> Members

        public ICollection<string> Keys
        {
            get { return this.innerDictionary.Keys; }
        }

        public ICollection<object> Values
        {
            get { return this.innerDictionary.Values; }
        }

        public object this[string key]
        {
            get { return this.innerDictionary[key]; }
            set { this.innerDictionary[key] = value; }
        }

        public void Add(string key, object value)
        {
            this.innerDictionary.Add(key, value);
        }

        public bool ContainsKey(string key)
        {
            return this.innerDictionary.ContainsKey(key);
        }

        public bool Remove(string key)
        {
            return this.innerDictionary.Remove(key);
        }

        public bool TryGetValue(string key, out object value)
        {
            return this.innerDictionary.TryGetValue(key, out value);
        }

        #endregion
    }

    public partial class TemplateContext
    {
        #region ICollection<KeyValuePair<string,object>> Members

        public int Count
        {
            get { return this.innerDictionary.Count; }
        }

        public bool IsReadOnly
        {
            get { return this.innerDictionary.IsReadOnly; }
        }

        public void Add(KeyValuePair<string, object> item)
        {
            this.innerDictionary.Add(item);
        }

        public void Clear()
        {
            this.innerDictionary.Clear();
        }

        public bool Contains(KeyValuePair<string, object> item)
        {
            return this.innerDictionary.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            this.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<string, object> item)
        {
            return this.innerDictionary.Remove(item);
        }

        #endregion
    }

    public partial class TemplateContext
    {
        #region IEnumerable<KeyValuePair<string,object>> Members

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return this.innerDictionary.GetEnumerator();
        }

        #endregion
    }

    public partial class TemplateContext
    {
        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.innerDictionary.GetEnumerator();
        }

        #endregion
    }
}