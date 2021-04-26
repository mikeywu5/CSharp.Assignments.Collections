using NUnit.Framework;
using System;
using System.Collections.Generic;
using Enumerables.Tests.Library;

namespace Enumerables.Tests
{
    public class YieldsTests
    {
        private Yields _object;

        public YieldsTests()
        {
            _object = new Yields();
        }

        [Test]
        public void FizzEnumerable()
        {
            IEnumerable<int> expected, actual;

            expected = new[] { 0, 1, 2, 3 };
            actual = _object.FizzEnumerable(4);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 0 };
            actual = _object.FizzEnumerable(1);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            actual = _object.FizzEnumerable(10);
            EnumAssert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.FizzEnumerable(0);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 0, 1 };
            actual = _object.FizzEnumerable(2);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 0, 1, 2, 3, 4, 5, 6 };
            actual = _object.FizzEnumerable(7);
            EnumAssert.Equal(expected, actual);

        }

        [Test]
        public void FizzEnumerable2()
        {

            IEnumerable<string> expected, actual;

            expected = new[] { "0", "1", "2", "3" };
            actual = _object.FizzEnumerable2(4);
            EnumAssert.Equal(expected, actual);

            expected = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            actual = _object.FizzEnumerable2(10);
            EnumAssert.Equal(expected, actual);

            expected = new[] { "0", "1" };
            actual = _object.FizzEnumerable2(2);
            EnumAssert.Equal(expected, actual);

            expected = new[] { "0" };
            actual = _object.FizzEnumerable2(1);
            EnumAssert.Equal(expected, actual);

            expected = new string[0];
            actual = _object.FizzEnumerable2(0);
            EnumAssert.Equal(expected, actual);

            expected = new[] { "0", "1", "2", "3", "4", "5", "6" };
            actual = _object.FizzEnumerable2(7);
            EnumAssert.Equal(expected, actual);

            expected = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
            actual = _object.FizzEnumerable2(9);
            EnumAssert.Equal(expected, actual);

            expected = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            actual = _object.FizzEnumerable2(11);
            EnumAssert.Equal(expected, actual);

        }

        [Test]
        public void FizzEnumerable3()
        {

            IEnumerable<int> expected, actual;

            expected = new[] { 5, 6, 7, 8, 9 };
            actual = _object.FizzEnumerable3(5, 10);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 11, 12, 13, 14, 15, 16, 17 };
            actual = _object.FizzEnumerable3(11, 18);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1, 2 };
            actual = _object.FizzEnumerable3(1, 3);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.FizzEnumerable3(1, 2);
            EnumAssert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.FizzEnumerable3(1, 1);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1000, 1001, 1002, 1003, 1004 };
            actual = _object.FizzEnumerable3(1000, 1005);
            EnumAssert.Equal(expected, actual);

        }

        [Test]
        public void SquareUp()
        {

            IEnumerable<int> expected, actual;

            expected = new[] { 0, 0, 1, 0, 2, 1, 3, 2, 1 };
            actual = _object.SquareUp(3);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 0, 1, 2, 1 };
            actual = _object.SquareUp(2);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 1, 0, 0, 2, 1, 0, 3, 2, 1, 4, 3, 2, 1 };
            actual = _object.SquareUp(4);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.SquareUp(1);
            EnumAssert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.SquareUp(0);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 2, 1, 0, 0, 0, 3, 2, 1, 0, 0, 4, 3, 2, 1, 0, 5, 4, 3, 2, 1, 6, 5, 4, 3, 2, 1 };
            actual = _object.SquareUp(6);
            EnumAssert.Equal(expected, actual);

        }

        [Test]
        public void SeriesUp()
        {

            IEnumerable<int> expected, actual;

            expected = new[] { 1, 1, 2, 1, 2, 3 };
            actual = _object.SeriesUp(3);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1, 1, 2, 1, 2, 3, 1, 2, 3, 4 };
            actual = _object.SeriesUp(4);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1, 1, 2 };
            actual = _object.SeriesUp(2);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.SeriesUp(1);
            EnumAssert.Equal(expected, actual);

            expected = new int[0];
            actual = _object.SeriesUp(0);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1, 1, 2, 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6 };
            actual = _object.SeriesUp(6);
            EnumAssert.Equal(expected, actual);

        }

        [Test]
        public void SkipTake()
        {
            IEnumerable<int> a = SampleArray();
            IEnumerable<int> actual, expected;
            expected = new int[0];
            actual = _object.SkipTake(null, 0, 0);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 2 };
            actual = _object.SkipTake(a, 0, 1);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 2, 16 };
            actual = _object.SkipTake(a, 0, 2);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 2, 16, 1 };
            actual = _object.SkipTake(a, 0, 3);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14 };
            actual = _object.SkipTake(a, 0, 4);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11 };
            actual = _object.SkipTake(a, 0, 6);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8 };
            actual = _object.SkipTake(a, 0, 9);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4 };
            actual = _object.SkipTake(a, 0, 14);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            actual = _object.SkipTake(a, 0, 22);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8 };
            actual = _object.SkipTake(a, 4, 1);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8, 11 };
            actual = _object.SkipTake(a, 4, 2);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8, 11, 11 };
            actual = _object.SkipTake(a, 4, 3);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8, 11, 11, 6 };
            actual = _object.SkipTake(a, 4, 4);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8, 11, 11, 6, 8, 17 };
            actual = _object.SkipTake(a, 4, 6);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8, 11, 11, 6, 8, 17, 14, 9, 0 };
            actual = _object.SkipTake(a, 4, 9);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9 };
            actual = _object.SkipTake(a, 4, 14);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8 };
            actual = _object.SkipTake(a, 8, 1);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8, 17 };
            actual = _object.SkipTake(a, 8, 2);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8, 17, 14 };
            actual = _object.SkipTake(a, 8, 3);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8, 17, 14, 9 };
            actual = _object.SkipTake(a, 8, 4);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8, 17, 14, 9, 0, 4 };
            actual = _object.SkipTake(a, 8, 6);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8, 17, 14, 9, 0, 4, 19, 13, 1 };
            actual = _object.SkipTake(a, 8, 9);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            actual = _object.SkipTake(a, 8, 14);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 0 };
            actual = _object.SkipTake(a, 12, 1);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 0, 4 };
            actual = _object.SkipTake(a, 12, 2);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 0, 4, 19 };
            actual = _object.SkipTake(a, 12, 3);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 0, 4, 19, 13 };
            actual = _object.SkipTake(a, 12, 4);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 0, 4, 19, 13, 1, 9 };
            actual = _object.SkipTake(a, 12, 6);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 0, 4, 19, 13, 1, 9, 7, 17, 20 };
            actual = _object.SkipTake(a, 12, 9);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = _object.SkipTake(a, 16, 1);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1, 9 };
            actual = _object.SkipTake(a, 16, 2);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1, 9, 7 };
            actual = _object.SkipTake(a, 16, 3);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1, 9, 7, 17 };
            actual = _object.SkipTake(a, 16, 4);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1, 9, 7, 17, 20, 3 };
            actual = _object.SkipTake(a, 16, 6);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 20 };
            actual = _object.SkipTake(a, 20, 1);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 20, 3 };
            actual = _object.SkipTake(a, 20, 2);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 3 };
            actual = _object.SkipTake(a, 21, 1);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 10, 11, 12, 13, 14 };
            actual = _object.SkipTake(Infinite(), 10, 5);
            EnumAssert.Equal(expected, actual);

            //var sb = new StringBuilder();


            //for (int i = 0; i <= 24; i += 4)
            //{
            //    int p = 0, q = 1;
            //    if (i == 24) i = 21;
            //    for (int j = i; j < a.Length; j = i + q)
            //    {
            //        q = p + q;
            //        p = q - p;
            //        sb.AppendLine($"expected = new [] {_object.SkipTake(a, i, j).ToCode()};");
            //        sb.AppendLine($"actual = _object.SkipTake(a, {i}, {j});");
            //        sb.AppendLine("EnumAssert.Equal(expected, actual);");
            //        sb.AppendLine();
            //    }
            //}
            //Assert.Fail(sb.ToString());

        }

        public IEnumerable<int> Infinite()
        {
            for (int i = 0; ; i++)
            {
                yield return i;
            }
        }

        [Test]
        public void Transfer()
        {

            IEnumerable<int> actual, expected, a;

            expected = new int[0];
            actual = _object.Transfer(null);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 20 };
            a = new[] { 20 };
            actual = _object.Transfer(a);
            Assert.False(ReferenceEquals(a, actual), "The copy cannot have the same reference");
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1, 2 };
            a = new[] { 1, 2 };
            actual = _object.Transfer(a);
            Assert.False(ReferenceEquals(a, actual), "The copy cannot have the same reference");
            EnumAssert.Equal(expected, actual);

            expected = new[] { -13, 34, 55 };
            a = new[] { -13, 34, 55 };
            actual = _object.Transfer(a);
            Assert.False(ReferenceEquals(a, actual), "The copy cannot have the same reference");
            EnumAssert.Equal(expected, actual);

            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            a = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            actual = _object.Transfer(a);
            Assert.False(ReferenceEquals(a, actual), "The copy cannot have the same reference");
            EnumAssert.Equal(expected, actual);

        }

        [Test]
        public void RotateOne()
        {

            IEnumerable<int> actual, expected;

            expected = new int[0];
            actual = null;
            actual = _object.Rotate(actual, false);
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 1 };
            actual = new[] { 1 }.ToEnumerable();
            actual = _object.Rotate(actual, false);
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 2, 1 };
            actual = new[] { 1, 2 }.ToEnumerable();
            actual = _object.Rotate(actual, false);
            EnumAssert.Equal(expected, actual);
            actual = new[] { 1, 2 }.ToEnumerable();
            actual = _object.Rotate(actual, true);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 3, 1, 2 };
            actual = new[] { 1, 2, 3 }.ToEnumerable();
            actual = _object.Rotate(actual, false);
            EnumAssert.Equal(expected, actual);

            expected = new[] { 2, 3, 1 };
            actual = new[] { 1, 2, 3 }.ToEnumerable();
            actual = _object.Rotate(actual, true);
            EnumAssert.Equal(expected, actual);

            actual = SampleArray();
            actual = _object.Rotate(actual, false);
            expected = new[] { 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20 }.ToEnumerable();
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, false);
            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            EnumAssert.Equal(expected, actual);

            actual = SampleArray();
            actual = _object.Rotate(actual, true);
            expected = new[] { 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 0, 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 4, 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 19, 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 13, 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 1, 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 9, 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 7, 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 17, 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 20, 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 3, 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20 };
            EnumAssert.Equal(expected, actual);
            actual = _object.Rotate(actual, true);
            expected = new[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 };
            EnumAssert.Equal(expected, actual);

        }

        private IEnumerable<int> SampleArray()
        {
            return new int[] { 2, 16, 1, 14, 8, 11, 11, 6, 8, 17, 14, 9, 0, 4, 19, 13, 1, 9, 7, 17, 20, 3 }.ToEnumerable();
        }
    }
}