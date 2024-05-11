using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components.Forms
{
    internal static class FormCache
    {
        private static Dictionary<Type, Dictionary<string, PropertyInfo>> cache = new();

        public static Dictionary<string, PropertyInfo>? GetCache<T>(Func<Dictionary<string, PropertyInfo>> createCache)
        {
            var type = typeof(T);
            if (!cache.ContainsKey(type))
            {
                CreateCache<T>(createCache.Invoke());
            }
            return cache[type];
        }

        private static void CreateCache<T>(Dictionary<string, PropertyInfo> data)
        {
            cache.Add(typeof(T), data);
        }
    }
}
