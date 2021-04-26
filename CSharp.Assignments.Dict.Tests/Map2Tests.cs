using System;
using System.Linq;
using System.Text;

using System.Collections.Generic;
using NUnit.Framework;

namespace CSharp.Assignments.Dict.Tests
{
    public class Map2Tests
    {
        private Map2 _object;
        [SetUp]
        public void Setup()
        {
            _object = new Map2();
        }

        [Test]
        [Category("Map 2")]
        public void Word0()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, int> { { "a", 0 }, { "b", 0 } };
            var actual = _object.Word0(new[] { "a", "b", "a", "b" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "a", 0 }, { "b", 0 }, { "c", 0 } };
            actual = _object.Word0(new[] { "a", "b", "a", "c", "b" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "a", 0 }, { "b", 0 }, { "c", 0 } };
            actual = _object.Word0(new[] { "c", "b", "a" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "c", 0 } };
            actual = _object.Word0(new[] { "c", "c", "c", "c" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int>();
            actual = _object.Word0(new string[0]);
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
        });
#endif
        }

        [Test]
        [Category("Map 2")]
        public void WordLen()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, int> { { "bb", 2 }, { "a", 1 } };
            var actual = _object.WordLen(new[] { "a", "bb", "a", "bb" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "that", 4 }, { "and", 3 }, { "this", 4 } };
            actual = _object.WordLen(new[] { "this", "and", "that", "and" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "code", 4 }, { "bug", 3 } };
            actual = _object.WordLen(new[] { "code", "code", "code", "bug" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int>();
            actual = _object.WordLen(new string[0]);
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "z", 1 } };
            actual = _object.WordLen(new[] { "z" });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
    });
#endif
        }

        [Test]
        [Category("Map 2")]
        public void Pairs()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, string> { { "b", "g" }, { "c", "e" } };
            var actual = _object.Pairs(new[] { "code", "bug" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "m", "n" } };
            actual = _object.Pairs(new[] { "man", "moon", "main" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "g", "d" }, { "m", "n" }, { "n", "t" } };
            actual = _object.Pairs(new[] { "man", "moon", "good", "night" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string>();
            actual = _object.Pairs(new string[0]);
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "a" }, { "b", "b" } };
            actual = _object.Pairs(new[] { "a", "b" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "d" }, { "c", "s" } };
            actual = _object.Pairs(new[] { "are", "codes", "and", "cods" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "e" }, { "b", "a" }, { "c", "e" }, { "t", "a" } };
            actual = _object.Pairs(new[] { "apple", "banana", "tea", "coffee" });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Map 2")]
        public void WordCount()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, int> { { "a", 2 }, { "b", 2 }, { "c", 1 } };
            var actual = _object.WordCount(new[] { "a", "b", "a", "c", "b" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "a", 1 }, { "b", 1 }, { "c", 1 } };
            actual = _object.WordCount(new[] { "c", "b", "a" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "c", 4 } };
            actual = _object.WordCount(new[] { "c", "c", "c", "c" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int>();
            actual = _object.WordCount(new string[0]);
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "", 1 }, { "and", 1 }, { "this", 2 } };
            actual = _object.WordCount(new[] { "this", "and", "this", "" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "x", 2 }, { "X", 1 }, { "y", 1 }, { "Y", 1 } };
            actual = _object.WordCount(new[] { "x", "y", "x", "Y", "X" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "0", 1 }, { "1", 1 }, { "123", 2 } };
            actual = _object.WordCount(new[] { "123", "0", "123", "1" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "a", 4 }, { "b", 5 }, { "d", 3 }, { "e", 1 }, { "f", 1 }, { "one", 1 }, { "x", 2 }, { "z", 2 }, { "two", 2 } };
            actual = _object.WordCount(new[] { "d", "a", "e", "d", "a", "d", "b", "b", "z", "a", "a", "b", "z", "x", "b", "f", "x", "two", "b", "one", "two" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, int> { { "banana", 2 }, { "apple", 3 }, { "tea", 1 }, { "coffee", 1 } };
            actual = _object.WordCount(new[] { "apple", "banana", "apple", "apple", "tea", "coffee", "banana" });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Map 2")]
        public void FirstChar()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, string> { { "s", "saltsoda" }, { "t", "teatoast" } };
            var actual = _object.FirstChar(new[] { "salt", "tea", "soda", "toast" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "aaaAA" }, { "b", "bb" }, { "c", "cccCC" }, { "d", "d" } };
            actual = _object.FirstChar(new[] { "aa", "bb", "cc", "aAA", "cCC", "d" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string>();
            actual = _object.FirstChar(new string[0]);
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "appleaardvark" }, { "b", "bellsbellsbells" }, { "s", "saltsun" }, { "z", "zen" } };
            actual = _object.FirstChar(new[] { "apple", "bells", "salt", "aardvark", "bells", "sun", "zen", "bells" });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Map 2")]
        public void WordAppend()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = "a";
            var actual = _object.WordAppend(new[] { "a", "b", "a" });
            Assert.AreEqual(expected, actual);

            expected = "aa";
            actual = _object.WordAppend(new[] { "a", "b", "a", "c", "a", "d", "a" });
            Assert.AreEqual(expected, actual);

            expected = "a";
            actual = _object.WordAppend(new[] { "a", "", "a" });
            Assert.AreEqual(expected, actual);

            expected = "";
            actual = _object.WordAppend(new string[0]);
            Assert.AreEqual(expected, actual);

            expected = "ba";
            actual = _object.WordAppend(new[] { "a", "b", "b", "a", "a" });
            Assert.AreEqual(expected, actual);

            expected = "baa";
            actual = _object.WordAppend(new[] { "a", "b", "b", "b", "a", "c", "a", "a" });
            Assert.AreEqual(expected, actual);

            expected = "baaba";
            actual = _object.WordAppend(new[] { "a", "b", "b", "b", "a", "c", "a", "a", "a", "b", "a" });
            Assert.AreEqual(expected, actual);

            expected = "andornot";
            actual = _object.WordAppend(new[] { "not", "and", "or", "and", "this", "and", "or", "that", "not" });
            Assert.AreEqual(expected, actual);

            expected = "";
            actual = _object.WordAppend(new[] { "a", "b", "c" });
            Assert.AreEqual(expected, actual);

            expected = "thisandthat";
            actual = _object.WordAppend(new[] { "this", "or", "that", "and", "this", "and", "that" });
            Assert.AreEqual(expected, actual);

            expected = "xxyyzzxx";
            actual = _object.WordAppend(new[] { "xx", "xx", "yy", "xx", "zz", "yy", "zz", "xx" });
            Assert.AreEqual(expected, actual);
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Map 2")]
        public void WordMultiple()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, bool> { { "a", true }, { "b", true }, { "c", false } };
            var actual = _object.WordMultiple(new[] { "a", "b", "a", "c", "b" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, bool> { { "a", false }, { "b", false }, { "c", false } };
            actual = _object.WordMultiple(new[] { "c", "b", "a" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, bool> { { "c", true } };
            actual = _object.WordMultiple(new[] { "c", "c", "c", "c" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, bool>();
            actual = _object.WordMultiple(new string[0]);
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, bool> { { "and", false }, { "this", true } };
            actual = _object.WordMultiple(new[] { "this", "and", "this" });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, bool> { { "a", true }, { "b", true }, { "d", true }, { "e", false }, { "x", false }, { "z", true } };
            actual = _object.WordMultiple(new[] { "d", "a", "e", "d", "a", "d", "b", "b", "z", "a", "a", "b", "z", "x" });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Map 2")]
        public void AllSwap()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new[] { "ac", "ab" };
            var actual = _object.AllSwap(new[] { "ab", "ac" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "ay", "by", "cy", "cx", "bx", "ax", "azz", "aaa" };
            actual = _object.AllSwap(new[] { "ax", "bx", "cx", "cy", "by", "ay", "aaa", "azz" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "ay", "by", "ax", "bx", "aj", "ai", "by", "bx" };
            actual = _object.AllSwap(new[] { "ax", "bx", "ay", "by", "ai", "aj", "bx", "by" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "ay", "bx", "cy", "ax", "cx", "abb", "aaa" };
            actual = _object.AllSwap(new[] { "ax", "bx", "cx", "ay", "cy", "aaa", "abb" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "every", "does", "ice", "easy", "it", "eaten" };
            actual = _object.AllSwap(new[] { "easy", "does", "it", "every", "ice", "eaten" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "lily", "over", "water", "swims", "of", "list", "words", "wait" };
            actual = _object.AllSwap(new[] { "list", "of", "words", "swims", "over", "lily", "water", "wait" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "42", "8", "16", "15", "23", "4" };
            actual = _object.AllSwap(new[] { "4", "8", "15", "16", "23", "42" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "aaa" };
            actual = _object.AllSwap(new[] { "aaa" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new string[0];
            actual = _object.AllSwap(new string[0]);
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "a", "b", "c", "xx", "yy", "zz" };
            actual = _object.AllSwap(new[] { "a", "b", "c", "xx", "yy", "zz" });
            CollectionAssert.AreEqual(expected, actual);
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Map 2")]
        public void FirstSwap()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new[] { "ac", "ab" };
            var actual = _object.FirstSwap(new[] { "ab", "ac" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "ay", "by", "cy", "cx", "bx", "ax", "aaa", "azz" };
            actual = _object.FirstSwap(new[] { "ax", "bx", "cx", "cy", "by", "ay", "aaa", "azz" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "ay", "by", "ax", "bx", "ai", "aj", "bx", "by" };
            actual = _object.FirstSwap(new[] { "ax", "bx", "ay", "by", "ai", "aj", "bx", "by" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "ay", "bx", "cy", "ax", "cx", "aaa", "abb" };
            actual = _object.FirstSwap(new[] { "ax", "bx", "cx", "ay", "cy", "aaa", "abb" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "every", "does", "ice", "easy", "it", "eaten" };
            actual = _object.FirstSwap(new[] { "easy", "does", "it", "every", "ice", "eaten" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "lily", "over", "water", "swims", "of", "list", "words", "wait" };
            actual = _object.FirstSwap(new[] { "list", "of", "words", "swims", "over", "lily", "water", "wait" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "42", "8", "16", "15", "23", "4" };
            actual = _object.FirstSwap(new[] { "4", "8", "15", "16", "23", "42" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "aaa" };
            actual = _object.FirstSwap(new[] { "aaa" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new string[0];
            actual = _object.FirstSwap(new string[0]);
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "a", "b", "c", "xx", "yy", "zz" };
            actual = _object.FirstSwap(new[] { "a", "b", "c", "xx", "yy", "zz" });
            CollectionAssert.AreEqual(expected, actual);
#if !DEBUG
});
#endif
        }
    }
}
