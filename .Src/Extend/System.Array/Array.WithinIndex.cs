﻿#region Usings

using System;
using JetBrains.Annotations;

#endregion

namespace Extend
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="Array" />.
    /// </summary>
    public static partial class ArrayEx
    {
        /// <summary>
        ///     Checks if the given index is within the array or not.
        /// </summary>
        /// <exception cref="ArgumentNullException">array can not be null.</exception>
        /// <param name="array">The array to check.</param>
        /// <param name="index">a Zero-based index.</param>
        /// <returns>Returns a value of true if the index is within the array, otherwise false.</returns>
        [PublicAPI]
        [Pure]
        public static Boolean WithinIndex( [NotNull] this Array array, Int32 index )
        {
            array.ThrowIfNull( nameof(array) );

            return index >= 0 && index < array.Length;
        }
    }
}