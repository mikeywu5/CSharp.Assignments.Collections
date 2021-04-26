using System;
using System.Collections.Generic;
using System.Text;

namespace Enumerables
{
    public class Yields
    {
        /// <summary>
        /// Given a number n, using yield return, return a int enumerable, containing the numbers 0, 1, 2, ... n-1. You do not need a separate if-statement for the length-0 case, return no elements; the for-loop should naturally execute 0 times in that case, so it just works.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public IEnumerable<int> FizzEnumerable(int number)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a number n, using yield return, return a string enumerable, containing the strings "0", "1" "2" .. through n-1. N may be 0, in which case just return no elements.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public IEnumerable<string> FizzEnumerable2(int number)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given start and end numbers, using yield return, return an enumerable containing the sequence of integers from start up to but not including end, so start=5 and end=10 yields {5, 6, 7, 8, 9}. The end number will be greater or equal to the start number.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public IEnumerable<int> FizzEnumerable3(int start, int end)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given n>=0, using yield return, using yield return, return an enumerable with the following pattern, shown here for n=3 : {0, 0, 1,    0, 2, 1,    3, 2, 1} (spaces added to show the 3 groups).
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public IEnumerable<int> SquareUp(int number)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given n>=0, using yield return, create an enumerable with the pattern {1,    1, 2,    1, 2, 3,   ... 1, 2, 3 .. n} (spaces added to show the grouping).
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public IEnumerable<int> SeriesUp(int number)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method will simply return new enumerable that skips a few numbers and then takes a number of values using foreach and yield return. Use yield break to end earlier. 
        /// </summary>

        /// <example>If your collection is { 2, 4, 6, 8, 10, 1, 3, 5, 7} and if the skipped is 3 and the taken is 4, the method will return a new enumerable is {8, 10, 1, 3}. </example>
        public IEnumerable<int> SkipTake(IEnumerable<int> collection, int skipped, int taken)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Using foreach and yield return, create a transfer of the enumerable (e.g. it should be the same as before).
        /// </summary>
        public IEnumerable<int> Transfer(IEnumerable<int> collection)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Using a foreach loop and yield return, the method will return a rotated enumerable. If rotatedLeft is true, then the enumerable will be rotated left by one position. If rotatedLeft is false, then the enumerable modified will be rotated right by one position.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="rotatedLeft">true to rotate left by one place, false to rotate right by one place.</param>
        /// <returns>an enumerable</returns>
        public IEnumerable<int> Rotate(IEnumerable<int> a, bool rotatedLeft)
        {
            throw new NotImplementedException();
        }
    }
}
