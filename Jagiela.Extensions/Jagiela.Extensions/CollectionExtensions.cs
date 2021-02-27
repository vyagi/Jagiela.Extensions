using System.Collections.Generic;
using System.Linq;

namespace Jagiela.Extensions
{
    public static class CollectionExtensions
    {
        public static T Second<T>(this IEnumerable<T> input) =>
            input.Skip(1).First();

        public static T? SecondOrDefault<T>(this IEnumerable<T> input) =>
            input.Skip(1).FirstOrDefault();
    }
}
