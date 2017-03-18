using System;
using System.Collections.Generic;
using System.Linq;

namespace Amoenus.NoneForLinq
{
    /// <summary>
    ///     Provides a set of extra static (Shared in Visual Basic) methods for querying objects
    ///     that implement System.Collections.Generic.IEnumerable`1.
    /// </summary>
    /// <seealso cref="System.Collections.Generic.IEnumerable{T}" />
    public static class Enumerable
    {
        /// <summary>
        ///     Determines whether a sequence contains none of the elements.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The System.Collections.Generic.IEnumerable`1 to check for emptiness.</param>
        /// <returns>
        ///     true if the source sequence contains none of the elements; otherwise, false.
        /// </returns>
        /// <seealso cref="System.Collections.Generic.IEnumerable{T}" />
        public static bool None<TSource>(this IEnumerable<TSource> source)
        {
            return !source.Any();
        }

        /// <summary>
        ///     Determines whether none of the elements of a sequence satisfies a condition.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">An System.Collections.Generic.IEnumerable`1 whose elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>
        ///     true if none of the elements in the source sequence pass the test in the specified predicate; otherwise,
        ///     false.
        /// </returns>
        /// <seealso cref="System.Collections.Generic.IEnumerable{T}" />
        public static bool None<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return !source.Any(predicate);
        }
    }
}