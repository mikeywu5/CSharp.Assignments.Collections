using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Enumerables.Tests.Library;

namespace Enumerables.Tests
{
    public class ForEachTests
    {
        private ForEach _object;
        public ForEachTests()
        {
            _object = new ForEach();
        }
        
        [Test]
        public void MaxValue()
        {
            Int32 expected, actual;

            expected = 0;
            actual = _object.MaxValue(null);
            Assert.AreEqual(expected, actual);

            expected = 0;
            actual = _object.MaxValue(new int[0].ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 5;
            actual = _object.MaxValue(new[] { 1, 4, 5, 2, 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 7;
            actual = _object.MaxValue(new[] { 6, 4, 7, 4, 2, 7, 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 6;
            actual = _object.MaxValue(new[] { 6 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void MinValue()
        {

            Int32 expected, actual;

            expected = 0;
            actual = _object.MinValue(null);
            Assert.AreEqual(expected, actual);

            expected = 0;
            actual = _object.MinValue(new int[0].ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 1;
            actual = _object.MinValue(new[] { 1, 4, 5, 2, 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 2;
            actual = _object.MinValue(new[] { 6, 4, 7, 4, 2, 7, 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 6;
            actual = _object.MinValue(new[] { 6 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void NeedleInHaystack()
        {

            Int32 expected, actual;

            expected = -1;
            actual = _object.NeedleInHaystack(null, 0);
            Assert.AreEqual(expected, actual);

            expected = -1;
            actual = _object.NeedleInHaystack(new int[0].ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = 0;
            actual = _object.NeedleInHaystack(new[] { 4, 5, 2, 8, 3, 7, 1 }.ToEnumerable(), 4);
            Assert.AreEqual(expected, actual);

            expected = 2;
            actual = _object.NeedleInHaystack(new[] { 4, 5, 2, 8, 3, 7, 1 }.ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = 6;
            actual = _object.NeedleInHaystack(new[] { 4, 5, 2, 8, 3, 7, 1 }.ToEnumerable(), 1);
            Assert.AreEqual(expected, actual);

            expected = -1;
            actual = _object.NeedleInHaystack(new[] { 4, 5, 2, 8, 3, 7, 1 }.ToEnumerable(), 6);
            Assert.AreEqual(expected, actual);

            expected = -1;
            actual = _object.NeedleInHaystack(new[] { 6 }.ToEnumerable(), 7);
            Assert.AreEqual(expected, actual);

            expected = 0;
            actual = _object.NeedleInHaystack(new[] { 6 }.ToEnumerable(), 6);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ClosestItem()
        {

            Int32 expected, actual;

            expected = 0;
            actual = _object.ClosestItem(null, 0);
            Assert.AreEqual(expected, actual);

            expected = 0;
            actual = _object.ClosestItem(new int[0].ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = 3;
            actual = _object.ClosestItem(new[] { 4, 5, 2, 8, 3, 7, 1 }.ToEnumerable(), 3);
            Assert.AreEqual(expected, actual);

            expected = 1;
            actual = _object.ClosestItem(new[] { 4, 5, 2, 8, 3, 7, 1 }.ToEnumerable(), 1);
            Assert.AreEqual(expected, actual);

            expected = 8;
            actual = _object.ClosestItem(new[] { 4, 5, 2, 8, 3, 7, 1 }.ToEnumerable(), 9);
            Assert.AreEqual(expected, actual);

            expected = 5;
            actual = _object.ClosestItem(new[] { 4, 5, 2, 9, 3, 8, 1 }.ToEnumerable(), 6);
            Assert.AreEqual(expected, actual);

            expected = 6;
            actual = _object.ClosestItem(new[] { 6 }.ToEnumerable(), 6);
            Assert.AreEqual(expected, actual);

            expected = 6;
            actual = _object.ClosestItem(new[] { 6 }.ToEnumerable(), -100);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void FarthestItem()
        {

            Int32 expected, actual;

            expected = 0;
            actual = _object.FarthestItem(null, 0);
            Assert.AreEqual(expected, actual);

            expected = 0;
            actual = _object.FarthestItem(new int[0].ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = 7;
            actual = _object.FarthestItem(new[] { 2, 3, 7, 4, 1, 5, 6 }.ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = 1;
            actual = _object.FarthestItem(new[] { 2, 3, 7, 4, 1, 5, 6 }.ToEnumerable(), 5);
            Assert.AreEqual(expected, actual);

            expected = 7;
            actual = _object.FarthestItem(new[] { 2, 3, 7, 4, 1, 5, 6 }.ToEnumerable(), -5);
            Assert.AreEqual(expected, actual);

            expected = 1;
            actual = _object.FarthestItem(new[] { 2, 3, 7, 4, 1, 5, 6 }.ToEnumerable(), 10);
            Assert.AreEqual(expected, actual);

            expected = 3;
            actual = _object.FarthestItem(new[] { 3 }.ToEnumerable(), 100);
            Assert.AreEqual(expected, actual);


        }

        [Test]
        public void BigDiff()
        {
            Int32 expected, actual;

            expected = 7;
            actual = _object.BigDiff(new[] { 10, 3, 5, 6 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 8;
            actual = _object.BigDiff(new[] { 7, 2, 10, 9 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 8;
            actual = _object.BigDiff(new[] { 2, 10, 7, 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 8;
            actual = _object.BigDiff(new[] { 2, 10 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 8;
            actual = _object.BigDiff(new[] { 10, 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 10;
            actual = _object.BigDiff(new[] { 10, 0 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 1;
            actual = _object.BigDiff(new[] { 2, 3 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 0;
            actual = _object.BigDiff(new[] { 2, 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 0;
            actual = _object.BigDiff(new[] { 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 8;
            actual = _object.BigDiff(new[] { 5, 1, 6, 1, 9, 9 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 3;
            actual = _object.BigDiff(new[] { 7, 6, 8, 5 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 3;
            actual = _object.BigDiff(new[] { 7, 7, 6, 8, 5, 5, 6 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 0;
            actual = _object.BigDiff(new int[0].ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 0;
            actual = _object.BigDiff(null);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void IsEverywhere()
        {

            Boolean expected, actual;

            expected = true;
            actual = _object.IsEverywhere(new[] { 1, 2, 1, 3 }.ToEnumerable(), 1);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 1, 2, 1, 3 }.ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 1, 2, 1, 3, 4 }.ToEnumerable(), 1);
            Assert.AreEqual(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 1 }.ToEnumerable(), 1);
            Assert.AreEqual(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 1 }.ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 3, 1 }.ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 3, 1 }.ToEnumerable(), 3);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 3, 1 }.ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 3 }.ToEnumerable(), 1);
            Assert.AreEqual(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new int[0].ToEnumerable(), 1);
            Assert.AreEqual(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 1, 2, 1, 2, 3, 2, 5 }.ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 1, 2, 1, 1, 1, 2 }.ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 1, 1, 2 }.ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 2, 2, 1, 1, 2 }.ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 2, 2, 1, 2, 1 }.ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

            expected = true;
            actual = _object.IsEverywhere(new[] { 2, 1, 2, 1, 2 }.ToEnumerable(), 2);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void CenteredAverage()
        {

            Int32 expected, actual;

            expected = 3;
            actual = _object.CenteredAverage(new[] { 1, 2, 3, 4, 100 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 5;
            actual = _object.CenteredAverage(new[] { 1, 1, 5, 5, 10, 8, 7 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = -3;
            actual = _object.CenteredAverage(new[] { -10, -4, -2, -4, -2, 0 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 4;
            actual = _object.CenteredAverage(new[] { 5, 3, 4, 6, 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 4;
            actual = _object.CenteredAverage(new[] { 5, 3, 4, 0, 100 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 4;
            actual = _object.CenteredAverage(new[] { 100, 0, 5, 3, 4 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 4;
            actual = _object.CenteredAverage(new[] { 4, 0, 100 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 3;
            actual = _object.CenteredAverage(new[] { 0, 2, 3, 4, 100 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 1;
            actual = _object.CenteredAverage(new[] { 1, 1, 100 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 7;
            actual = _object.CenteredAverage(new[] { 7, 7, 7 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 7;
            actual = _object.CenteredAverage(new[] { 1, 7, 8 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 50;
            actual = _object.CenteredAverage(new[] { 1, 1, 99, 99 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 50;
            actual = _object.CenteredAverage(new[] { 1000, 0, 1, 99 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 4;
            actual = _object.CenteredAverage(new[] { 4, 4, 4, 4, 5 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 4;
            actual = _object.CenteredAverage(new[] { 4, 4, 4, 1, 5 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 6;
            actual = _object.CenteredAverage(new[] { 6, 4, 8, 12, 3 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void AloneEvenAverage()
        {

            double actual, expected;

            expected = 0;
            actual = _object.AloneEvenAverage(new int[0].ToEnumerable());
            Assert.AreEqual(expected, actual, 3);

            expected = 0;
            actual = _object.AloneEvenAverage(null);
            Assert.AreEqual(expected, actual, 3);

            expected = 0;
            actual = _object.AloneEvenAverage(new[] { 1, 3, 5, 7 }.ToEnumerable());
            Assert.AreEqual(expected, actual, 3);

            expected = 0;
            actual = _object.AloneEvenAverage(new[] { 2, 4 }.ToEnumerable());
            Assert.AreEqual(expected, actual, 3);

            expected = 2;
            actual = _object.AloneEvenAverage(new[] { 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual, 3);

            expected = 2;
            actual = _object.AloneEvenAverage(new[] { 2, 1 }.ToEnumerable());
            Assert.AreEqual(expected, actual, 3);

            expected = 2;
            actual = _object.AloneEvenAverage(new[] { 3, 2, 1 }.ToEnumerable());
            Assert.AreEqual(expected, actual, 3);

            expected = 6.4;
            actual = _object.AloneEvenAverage(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12 }.ToEnumerable());
            Assert.AreEqual(expected, actual, 3);


            expected = 3;
            actual = _object.AloneEvenAverage(new[] { 1, 2, 4, 3, 4, 8, 0, 5, 6, 7, 8, 6, -2, 9, 0 }.ToEnumerable());
            Assert.AreEqual(expected, actual, 3);

            expected = 0.8;
            actual = _object.AloneEvenAverage(new[] { 2, -1, 4, 3, 4, -8, 0, 5, 6, 7, -8, 9, 0, 1 }.ToEnumerable());
            Assert.AreEqual(expected, actual, 3);

            expected = -1.6;
            actual = _object.AloneEvenAverage(new[] { -2, -1, -4, 3, 4, -8, 0, 5, 6, 7, -8, 9, 0, 1 }.ToEnumerable());
            Assert.AreEqual(expected, actual, 3);

            expected = -2.4;
            actual = _object.AloneEvenAverage(new[] { -6, -1, -4, 3, 4, -2, 0, 5, 6, 7, -8, 9, 0, 1 }.ToEnumerable());
            Assert.AreEqual(expected, actual, 3);

            expected = 0;
            actual = _object.AloneEvenAverage(new[] { 0, 1, 2, 4, 3, 4, -8, 0, 5, 6, 7, -8, 9, 0, 1, -2, -3, 4 }.ToEnumerable());
            Assert.AreEqual(expected, actual, 3);

        }

        [Test]
        public void CountClumps()
        {

            Int32 expected, actual;

            expected = 2;
            actual = _object.CountClumps(new[] { 1, 2, 2, 3, 4, 4 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 2;
            actual = _object.CountClumps(new[] { 1, 1, 2, 1, 1 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 1;
            actual = _object.CountClumps(new[] { 1, 1, 1, 1, 1 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 0;
            actual = _object.CountClumps(new[] { 1, 2, 3 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 4;
            actual = _object.CountClumps(new[] { 2, 2, 1, 1, 1, 2, 1, 1, 2, 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 4;
            actual = _object.CountClumps(new[] { 0, 2, 2, 1, 1, 1, 2, 1, 1, 2, 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 5;
            actual = _object.CountClumps(new[] { 0, 0, 2, 2, 1, 1, 1, 2, 1, 1, 2, 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 5;
            actual = _object.CountClumps(new[] { 0, 0, 0, 2, 2, 1, 1, 1, 2, 1, 1, 2, 2 }.ToEnumerable());
            Assert.AreEqual(expected, actual);

            expected = 0;
            actual = _object.CountClumps(new int[0].ToEnumerable());
            Assert.AreEqual(expected, actual);

        }
    }
}
