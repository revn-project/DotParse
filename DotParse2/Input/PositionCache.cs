using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DotParse.Input
{
    internal sealed class PositionCache
    {
        private readonly ConditionalWeakTable<IEnumerable<char>, int[]> _cache;

        public PositionCache()
        {
            _cache = new ConditionalWeakTable<IEnumerable<char>, int[]>();
        }

        public int[] Get(IEnumerable<char> key) => _cache.TryGetValue(key, out int[] result) ? result : null;

        public void Add(IEnumerable<char> key, int[] value) => _cache.Add(key, value);
    }
}