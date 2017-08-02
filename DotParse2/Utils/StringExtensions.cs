using System.Collections;
using System.Collections.Generic;

namespace DotParse.Utils
{
    internal static class StringExtensions
    {
        public static string Join(this IEnumerable<char> that)
            => string.Join(string.Empty, that);
    }
}