using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rts.Interview
{
    public class CacheImplementation<T> : ICache<T> where T : class
    {
        private IDictionary<string, T> cache;
        private int maxSize;

        public CacheImplementation(int size)
        {
            cache = new Dictionary<string, T>();
            SetMaxSize(size);
        }

        public T Get(string key)
        {
            if (cache == null)
            {
                return null;
            }
            if (cache.ContainsKey(key))
            {
                return cache[key];
            }
            return null;
        }

        public void Put(string key, T value)
        {
            if (cache != null)
            {
                if (cache.ContainsKey(key))
                {
                    cache[key] = value;
                }
                else
                {
                    cache.Add(key, value);
                }
                if (cache.Count() > GetMaxSize())
                {
                    EjectNext();
                }
            }
        }

        public int GetCurrentCacheSize() => cache.Count();

        public int GetMaxSize() => this.maxSize;

        public void SetMaxSize(int maxSize)
        {
            if(maxSize < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxSize));
            }

            if (maxSize < this.maxSize)
            {
                while (GetCurrentCacheSize() > maxSize)
                {
                    EjectNext();
                }
            }

            this.maxSize = maxSize;
        }

        private void EjectNext()
        {
            if (cache.Any())
            {
                cache.Remove(cache.FirstOrDefault());
            }
        }
    }

    public class CachedItem<T>
    {
        public T Value { get; set; }
        public DateTime DateAdded;

        public CachedItem(T value)
        {
            Value = value;
            DateAdded = DateTime.Now;
        }

        public bool AddedBefore(CachedItem<T> other)
        {
            return this.DateAdded < other.DateAdded;
        }
    }
}
