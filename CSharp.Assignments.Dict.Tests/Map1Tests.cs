using System;
using System.Linq;
using System.Text;

using System.Collections.Generic;
using NUnit.Framework;

namespace CSharp.Assignments.Dict.Tests
{
    public class Map1Tests
    {
        private Map1 _object;
        [SetUp]
        public void Setup()
        {
            _object = new Map1();
        }

        [Test]
        [Category("Map 1")]
        public void MapBully()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, string> { { "a", "" }, { "b", "candy" } };
            var actual = _object.MapBully(new Dictionary<string, string> { { "a", "candy" }, { "b", "dirt" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "" }, { "b", "candy" } };
            actual = _object.MapBully(new Dictionary<string, string> { { "a", "candy" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "" }, { "b", "candy" }, { "c", "meh" } };
            actual = _object.MapBully(new Dictionary<string, string> { { "a", "candy" }, { "b", "carrot" }, { "c", "meh" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "b", "carrot" } };
            actual = _object.MapBully(new Dictionary<string, string> { { "b", "carrot" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "c", "meh" } };
            actual = _object.MapBully(new Dictionary<string, string> { { "c", "meh" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "" }, { "b", "sparkle" }, { "c", "meh" } };
            actual = _object.MapBully(new Dictionary<string, string> { { "a", "sparkle" }, { "c", "meh" } });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
        });
#endif
        }

        [Test]
        [Category("Map 1")]
        public void MapShare()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, string> { { "a", "aaa" }, { "b", "aaa" } };
            var actual = _object.MapShare(new Dictionary<string, string> { { "a", "aaa" }, { "b", "bbb" }, { "c", "ccc" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "b", "xyz" } };
            actual = _object.MapShare(new Dictionary<string, string> { { "b", "xyz" }, { "c", "ccc" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "aaa" }, { "b", "aaa" }, { "d", "hi" } };
            actual = _object.MapShare(new Dictionary<string, string> { { "a", "aaa" }, { "c", "meh" }, { "d", "hi" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "xyz" }, { "b", "xyz" }, { "z", "zzz" } };
            actual = _object.MapShare(new Dictionary<string, string> { { "a", "xyz" }, { "b", "1234" }, { "c", "yo" }, { "z", "zzz" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "xyz" }, { "b", "xyz" }, { "d", "ddd" }, { "e", "everything" } };
            actual = _object.MapShare(new Dictionary<string, string> { { "a", "xyz" }, { "b", "1234" }, { "c", "yo" }, { "d", "ddd" }, { "e", "everything" } });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
    });
#endif
        }

        [Test]
        [Category("Map 1")]
        public void MapAB()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, string> { { "a", "Hi" }, { "ab", "HiThere" }, { "b", "There" } };
            var actual = _object.MapAB(new Dictionary<string, string> { { "a", "Hi" }, { "b", "There" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "Hi" } };
            actual = _object.MapAB(new Dictionary<string, string> { { "a", "Hi" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "b", "There" } };
            actual = _object.MapAB(new Dictionary<string, string> { { "b", "There" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "c", "meh" } };
            actual = _object.MapAB(new Dictionary<string, string> { { "c", "meh" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "aaa" }, { "ab", "aaabbb" }, { "b", "bbb" }, { "c", "ccc" } };
            actual = _object.MapAB(new Dictionary<string, string> { { "a", "aaa" }, { "ab", "nope" }, { "b", "bbb" }, { "c", "ccc" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "ab", "nope" }, { "b", "bbb" }, { "c", "ccc" } };
            actual = _object.MapAB(new Dictionary<string, string> { { "ab", "nope" }, { "b", "bbb" }, { "c", "ccc" } });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Map 1")]
        public void Topping1()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, string> { { "bread", "butter" }, { "ice cream", "cherry" } };
            var actual = _object.Topping1(new Dictionary<string, string> { { "ice cream", "peanuts" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "bread", "butter" } };
            actual = _object.Topping1(new Dictionary<string, string>());
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "bread", "butter" }, { "pancake", "syrup" } };
            actual = _object.Topping1(new Dictionary<string, string> { { "pancake", "syrup" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "bread", "butter" }, { "ice cream", "cherry" } };
            actual = _object.Topping1(new Dictionary<string, string> { { "bread", "dirt" }, { "ice cream", "strawberries" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "bread", "butter" }, { "ice cream", "cherry" }, { "salad", "oil" } };
            actual = _object.Topping1(new Dictionary<string, string> { { "bread", "jam" }, { "ice cream", "strawberries" }, { "salad", "oil" } });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Map 1")]
        public void Topping2()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, string> { { "yogurt", "cherry" }, { "ice cream", "cherry" } };
            var actual = _object.Topping2(new Dictionary<string, string> { { "ice cream", "cherry" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "yogurt", "cherry" }, { "spinach", "nuts" }, { "ice cream", "cherry" } };
            actual = _object.Topping2(new Dictionary<string, string> { { "spinach", "dirt" }, { "ice cream", "cherry" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "yogurt", "salt" } };
            actual = _object.Topping2(new Dictionary<string, string> { { "yogurt", "salt" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "yogurt", "salt" }, { "bread", "butter" } };
            actual = _object.Topping2(new Dictionary<string, string> { { "yogurt", "salt" }, { "bread", "butter" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string>();
            actual = _object.Topping2(new Dictionary<string, string>());
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "yogurt", "air" }, { "ice cream", "air" }, { "salad", "oil" } };
            actual = _object.Topping2(new Dictionary<string, string> { { "ice cream", "air" }, { "salad", "oil" } });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Map 1")]
        public void Topping3()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, string> { { "potato", "ketchup" }, { "fries", "ketchup" } };
            var actual = _object.Topping3(new Dictionary<string, string> { { "potato", "ketchup" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "potato", "butter" }, { "fries", "butter" } };
            actual = _object.Topping3(new Dictionary<string, string> { { "potato", "butter" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "spinach", "oil" }, { "salad", "oil" }, { "potato", "ketchup" }, { "fries", "ketchup" } };
            actual = _object.Topping3(new Dictionary<string, string> { { "salad", "oil" }, { "potato", "ketchup" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "toast", "butter" }, { "spinach", "oil" }, { "salad", "oil" }, { "potato", "ketchup" }, { "fries", "ketchup" } };
            actual = _object.Topping3(new Dictionary<string, string> { { "toast", "butter" }, { "salad", "oil" }, { "potato", "ketchup" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string>();
            actual = _object.Topping3(new Dictionary<string, string>());
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "spinach", "pepper" }, { "salad", "pepper" }, { "fries", "salt" } };
            actual = _object.Topping3(new Dictionary<string, string> { { "salad", "pepper" }, { "fries", "salt" } });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Map 1")]
        public void MapAB2()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, string> { { "c", "cake" } };
            var actual = _object.MapAB2(new Dictionary<string, string> { { "a", "aaa" }, { "b", "aaa" }, { "c", "cake" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "aaa" }, { "b", "bbb" } };
            actual = _object.MapAB2(new Dictionary<string, string> { { "a", "aaa" }, { "b", "bbb" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "aaa" }, { "b", "bbb" }, { "c", "aaa" } };
            actual = _object.MapAB2(new Dictionary<string, string> { { "a", "aaa" }, { "b", "bbb" }, { "c", "aaa" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "aaa" } };
            actual = _object.MapAB2(new Dictionary<string, string> { { "a", "aaa" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "b", "bbb" } };
            actual = _object.MapAB2(new Dictionary<string, string> { { "b", "bbb" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "c", "ccc" } };
            actual = _object.MapAB2(new Dictionary<string, string> { { "a", "" }, { "b", "" }, { "c", "ccc" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string>();
            actual = _object.MapAB2(new Dictionary<string, string>());
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "a" }, { "b", "b" }, { "z", "zebra" } };
            actual = _object.MapAB2(new Dictionary<string, string> { { "a", "a" }, { "b", "b" }, { "z", "zebra" } });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }

        [Test]
        [Category("Map 1")]
        public void MapAB3()
        {
#if !DEBUG
        Assert.Multiple(() => {
#endif
            var expected = new Dictionary<string, string> { { "a", "aaa" }, { "b", "aaa" }, { "c", "cake" } };
            var actual = _object.MapAB3(new Dictionary<string, string> { { "a", "aaa" }, { "c", "cake" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "bbb" }, { "b", "bbb" }, { "c", "cake" } };
            actual = _object.MapAB3(new Dictionary<string, string> { { "b", "bbb" }, { "c", "cake" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "aaa" }, { "b", "bbb" }, { "c", "cake" } };
            actual = _object.MapAB3(new Dictionary<string, string> { { "a", "aaa" }, { "b", "bbb" }, { "c", "cake" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "ccc", "ccc" } };
            actual = _object.MapAB3(new Dictionary<string, string> { { "ccc", "ccc" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "c", "a" }, { "d", "b" } };
            actual = _object.MapAB3(new Dictionary<string, string> { { "c", "a" }, { "d", "b" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string>();
            actual = _object.MapAB3(new Dictionary<string, string>());
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "" }, { "b", "" } };
            actual = _object.MapAB3(new Dictionary<string, string> { { "a", "" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "" }, { "b", "" } };
            actual = _object.MapAB3(new Dictionary<string, string> { { "b", "" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "a", "" }, { "b", "" } };
            actual = _object.MapAB3(new Dictionary<string, string> { { "a", "" }, { "b", "" } });
            CollectionAssert.AreEquivalent(expected, actual);

            expected = new Dictionary<string, string> { { "aa", "aa" }, { "a", "apple" }, { "b", "apple" }, { "z", "zzz" } };
            actual = _object.MapAB3(new Dictionary<string, string> { { "aa", "aa" }, { "a", "apple" }, { "z", "zzz" } });
            CollectionAssert.AreEquivalent(expected, actual);
#if !DEBUG
});
#endif
        }
    }
}
