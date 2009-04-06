namespace Lsd.NJean.Tests
{
#region imports
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
#endregion
    public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private IDictionary<TKey, TValue> dict;

        public ReadOnlyDictionary(IDictionary<TKey, TValue> backingDict)
        {
            this.dict = backingDict;
        }

        public ICollection<TKey> Keys
        {
            get { return this.dict.Keys; }
        }

        public int Count
        {
            get { return this.dict.Count; }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        public ICollection<TValue> Values
        {
            get { return this.dict.Values; }
        }

        public TValue this[TKey key]
        {
            get { return this.dict[key]; }
            set { throw new InvalidOperationException(); }
        }

        public void Add(TKey key, TValue value)
        {
            throw new InvalidOperationException();
        }

        public bool ContainsKey(TKey key)
        {
            return this.dict.ContainsKey(key);
        }

        public bool Remove(TKey key)
        {
            throw new InvalidOperationException();
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return this.dict.TryGetValue(key, out value);
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            throw new InvalidOperationException();
        }

        public void Clear()
        {
            throw new InvalidOperationException();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return this.dict.ContainsKey(item.Key);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            this.dict.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new InvalidOperationException();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return this.dict.GetEnumerator();
        }

        System.Collections.IEnumerator
               System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.IEnumerable)this.dict).GetEnumerator();
        }
    }
}
