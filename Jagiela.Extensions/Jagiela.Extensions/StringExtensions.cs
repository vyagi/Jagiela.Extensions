using System.Collections.Generic;

namespace Jagiela.Extensions
{
    public static class StringExtensions
    {
        public static string JoinWith(this IEnumerable<string> input, string separator) =>
            string.Join(separator, input);
    }
}