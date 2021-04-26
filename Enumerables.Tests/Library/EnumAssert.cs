using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using NUnit.Framework;

namespace Enumerables.Tests.Library
{
    [DebuggerNonUserCode]
    public static class EnumAssert
    {
        public static void Equal<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            Assert.IsNotInstanceOf<ICollection>(actual, "The enumerable cannot be a collection: use yield return.");
            Assert.IsNotInstanceOf<ICollection<T>>(actual, "The enuemrable cannot be a collection: use yield return.");
            Assert.IsNotInstanceOf<IReadOnlyCollection<T>>(actual, "The enuemrable cannot be a collection: use yield return.");
            CollectionAssert.AreEqual(expected, actual);
        }

        public static IEnumerable<T> ToEnumerable<T>(this T[] array)
        {
            foreach(var value in array)
            {
                yield return value;
            }
        }
    }
}
