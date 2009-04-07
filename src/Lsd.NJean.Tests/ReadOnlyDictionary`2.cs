// <copyright file="ReadOnlyDictionary`2.cs" company="Liquid Software Development">
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
    
    #endregion

    public partial class ReadOnlyDictionary<TKey, TValue> 
        : Dictionary<TKey, TValue>, IDictionary<TKey, TValue>
    {
        #region Constructors

        public ReadOnlyDictionary()
        {
        }

        public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
            : base(dictionary)
        {
        }
        
        #endregion
    }

    public partial class ReadOnlyDictionary<TKey, TValue>
    {
        #region IDictionary<TKey,TValue> Members

        TValue IDictionary<TKey, TValue>.this[TKey key]
        {
            get { return this[key]; }
            set { throw new NotSupportedException(); }
        }
        
        void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
        {
            throw new NotSupportedException();
        }

        bool IDictionary<TKey, TValue>.Remove(TKey key)
        {
            throw new NotSupportedException();
        }

        #endregion
    }

    public partial class ReadOnlyDictionary<TKey, TValue>
    {
        #region ICollection<KeyValuePair<TKey,TValue>> Members

        bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
        {
            get { return true; }
        }
        
        void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
        {
            throw new NotSupportedException();
        }

        void ICollection<KeyValuePair<TKey, TValue>>.Clear()
        {
            throw new NotSupportedException();
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotSupportedException();
        }

        #endregion
    }
}