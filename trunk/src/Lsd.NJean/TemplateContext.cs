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

    /// <summary>
    /// TemplateContext is a simple implementation of ITemplateContext using
    /// an inner IDictionary&lt;string, object&gt;
    /// </summary>
    /// <author>
    /// <a href="mailto:diadistis@gmail.com">Diadistis</a>
    /// </author>
    [SuppressMessage
        ("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix",
        Justification = "Context is a much better suffix than Dictionary.")]
    public sealed partial class TemplateContext : ITemplateContext
    {
        #region Fields

        private readonly IDictionary<string, object> innerDictionary =
            new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateContext"/> class.
        /// </summary>
        public TemplateContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateContext"/> class.
        /// </summary>
        /// <param name="context">Base context.</param>
        public TemplateContext(TemplateContext context)
            : this((IDictionary<string, object>)context)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateContext"/> class.
        /// </summary>
        /// <param name="context">Base context.</param>
        public TemplateContext(IDictionary<string, object> context)
        {
            foreach (KeyValuePair<string, object> pair in context)
            {
                this.innerDictionary.Add(pair);
            }
        }

        #endregion
    }

    public partial class TemplateContext
    {
        #region IDictionary<string,object> Members

        /// <summary>
        /// Gets an <see cref="T:System.Collections.Generic.ICollection`1"/>
        /// containing the keys of the <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.Generic.ICollection`1"/> 
        /// containing the keys of the <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </returns>
        public ICollection<string> Keys
        {
            get { return this.innerDictionary.Keys; }
        }

        /// <summary>
        /// Gets an <see cref="T:System.Collections.Generic.ICollection`1"/>
        /// containing the values in the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.Generic.ICollection`1"/> 
        /// containing the values in the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </returns>
        public ICollection<object> Values
        {
            get { return this.innerDictionary.Values; }
        }

        /// <summary>
        /// Gets or sets the <see cref="System.Object"/> with the specified key.
        /// </summary>
        /// <param name="key">
        /// he string to use as the key of the element to get or set.
        /// </param>
        public object this[string key]
        {
            get { return this.innerDictionary[key]; }
            set { this.innerDictionary[key] = value; }
        }

        /// <summary>
        /// Adds an element with the provided key and value to the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </summary>
        /// <param name="key">
        /// The string to use as the key of the element to add.
        /// </param>
        /// <param name="value">
        /// The object to use as the value of the element to add.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="key"/> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// An element with the same key already exists in the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        /// The <see cref="T:Lsd.NJean.TemplateContext"/> is read-only.
        /// </exception>
        public void Add(string key, object value)
        {
            this.innerDictionary.Add(key, value);
        }

        /// <summary>
        /// Determines whether the <see cref="T:Lsd.NJean.TemplateContext"/>
        /// contains an element with the specified key.
        /// </summary>
        /// <param name="key">
        /// The key to locate in the <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </param>
        /// <returns>
        /// true if the <see cref="T:Lsd.NJean.TemplateContext"/> 
        /// contains an element with the key; otherwise, false.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="key"/> is null.
        /// </exception>
        public bool ContainsKey(string key)
        {
            return this.innerDictionary.ContainsKey(key);
        }

        /// <summary>
        /// Removes the element with the specified key from the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </summary>
        /// <param name="key">The key of the element to remove.</param>
        /// <returns>
        /// true if the element is successfully removed; otherwise, false.
        /// This method also returns false if <paramref name="key"/> was not
        /// found in the original <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="key"/> is null.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        /// The <see cref="T:Lsd.NJean.TemplateContext"/> is read-only.
        /// </exception>
        public bool Remove(string key)
        {
            return this.innerDictionary.Remove(key);
        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key whose value to get.</param>
        /// <param name="value">
        /// When this method returns, the value associated 
        /// with the specified key, if the key is found; otherwise, the default
        /// value for the type of the <paramref name="value"/> parameter.
        /// This parameter is passed uninitialized.
        /// </param>
        /// <returns>
        /// true if the <see cref="T:Lsd.NJean.TemplateContext"/> contains an 
        /// element with the specified key; otherwise, false.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="key"/> is null.
        /// </exception>
        public bool TryGetValue(string key, out object value)
        {
            return this.innerDictionary.TryGetValue(key, out value);
        }

        #endregion
    }

    public partial class TemplateContext
    {
        #region ICollection<KeyValuePair<string,object>> Members
        
        /// <summary>
        /// Gets the number of elements contained in the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </summary>
        /// <returns>
        /// The number of elements contained in the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </returns>
        public int Count
        {
            get { return this.innerDictionary.Count; }
        }

        /// <summary>
        /// Gets a value indicating whether the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/> is read-only.
        /// </summary>
        /// <returns>
        /// true if the <see cref="T:Lsd.NJean.TemplateContext"/> is read-only;
        /// otherwise, false.
        /// </returns>
        public bool IsReadOnly
        {
            get { return this.innerDictionary.IsReadOnly; }
        }

        /// <summary>
        /// Adds an item to the <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </summary>
        /// <param name="item">
        /// The object to add to the <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </param>
        public void Add(KeyValuePair<string, object> item)
        {
            this.innerDictionary.Add(item);
        }

        /// <summary>
        /// Removes all items from the <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </summary>
        public void Clear()
        {
            this.innerDictionary.Clear();
        }

        /// <summary>
        /// Determines whether the <see cref="T:Lsd.NJean.TemplateContext"/> 
        /// contains a specific value.
        /// </summary>
        /// <param name="item">
        /// The object to locate in the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </param>
        /// <returns>
        /// true if <paramref name="item"/> is found in the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/>; otherwise, false.
        /// </returns>
        public bool Contains(KeyValuePair<string, object> item)
        {
            return this.innerDictionary.Contains(item);
        }

        /// <summary>
        /// Copies the elements of the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/> to an 
        /// <see cref="T:System.Array"/>, starting at a particular 
        /// <see cref="T:System.Array"/> index.
        /// </summary>
        /// <param name="array">
        /// The one-dimensional <see cref="T:System.Array"/> that is the 
        /// destination of the elements copied from 
        /// <see cref="T:Lsd.NJean.TemplateContext"/>. The 
        /// <see cref="T:System.Array"/> must have zero-based indexing.
        /// </param>
        /// <param name="arrayIndex">
        /// The zero-based index in <paramref name="array"/> at which copying 
        /// begins.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="array"/> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// <paramref name="arrayIndex"/> is less than 0.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="array"/>
        /// is multidimensional.
        /// -or-
        /// <paramref name="arrayIndex"/> is equal to or greater than the length
        /// of <paramref name="array"/>.
        /// -or-
        /// The number of elements in the source 
        /// <see cref="T:Lsd.NJean.TemplateContext"/> is greater than the 
        /// available space from <paramref name="arrayIndex"/> to the end of 
        /// the destination <paramref name="array"/>.
        /// -or-
        /// Type <paramref name="T"/> cannot be cast automatically to the type 
        /// of the destination <paramref name="array"/>.
        /// </exception>
        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            this.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Removes the first occurrence of a specific object from the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </summary>
        /// <param name="item">
        /// The object to remove from the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </param>
        /// <returns>
        /// true if <paramref name="item"/> was successfully removed from the 
        /// <see cref="T:Lsd.NJean.TemplateContext"/>; otherwise, false. 
        /// This method also returns false if <paramref name="item"/> is not 
        /// found in the original <see cref="T:Lsd.NJean.TemplateContext"/>.
        /// </returns>
        /// <exception cref="T:System.NotSupportedException">
        /// The <see cref="T:System.Collections.Generic.ICollection`1"/> 
        /// is read-only.
        /// </exception>
        public bool Remove(KeyValuePair<string, object> item)
        {
            return this.innerDictionary.Remove(item);
        }

        #endregion
    }

    public partial class TemplateContext
    {
        #region IEnumerable<KeyValuePair<string,object>> Members
        
        /// <summary>
        /// Returns an enumerator that iterates through the context.
        /// </summary>
        /// <returns>
        /// A <see cref="T:Lsd.NJean.TemplateContext"/> that can be used to 
        /// iterate through the collection.
        /// </returns>
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return this.innerDictionary.GetEnumerator();
        }

        #endregion
    }

    public partial class TemplateContext
    {
        #region IEnumerable Members
        
        /// <summary>
        /// Returns an enumerator that iterates through the context.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator"/> 
        /// object that can be used to iterate through the context.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.innerDictionary.GetEnumerator();
        }

        #endregion
    }
}