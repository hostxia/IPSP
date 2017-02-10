using Abp.Runtime.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSP
{
    public static class IPSPCache
    {
        public static ICacheManager Instance
        {
            get;
            private set;
        }

        public static void InitialCache()
        {
            //TODO Create caches
        }

        public static void CreateCache<TKey, TValue>(this List<TValue> listCache, Func<TValue, TKey> func, string cacheName)
        {
            listCache.CreateCache(func, (list) => list, cacheName);
        }

        public static void CreateCache<TSrouce, TKey, TValue>(this List<TSrouce> listCache, Func<TSrouce, TKey> funcKey, Func<TSrouce, TValue> funcValue, string cacheName)
        {
            Instance.GetCache<TKey, TValue>(cacheName).DefaultSlidingExpireTime = TimeSpan.MaxValue;
            Instance.GetCache<TKey, TValue>(cacheName).Clear();
            foreach (var obj in listCache)
            {
                Instance.GetCache<TKey, TValue>(cacheName).Set(funcKey(obj), funcValue(obj));
            }
        }
    }
}
