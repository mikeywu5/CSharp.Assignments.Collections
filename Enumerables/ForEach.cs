using System;
using System.Collections.Generic;
using System.Text;

namespace Enumerables
{
    public class ForEach
    {
        /// <summary>
        /// Using foreach loop, find the minimum value of the enumerable
        /// </summary>
        /// <param name="enumerable"></param>
        /// <returns>min value, or if the enumerable is null or empty, simply return 0</returns>
        public int MinValue(IEnumerable<int> enumerable)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Using foreach loop, find the maximum value of the enumerable
        /// </summary>
        /// <param name="enumerable"></param>
        /// <returns>the last element, or 0 if the enumerable is empty or null</returns>
        public int MaxValue(IEnumerable<int> enumerable)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Using foreach loop, find an element in the enumerable.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <param name="item"></param>
        /// <returns>Index of the element; -1 if not found.</returns>
        public int NeedleInHaystack(IEnumerable<int> enumerable, int item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Using foreach loop, find the int that's closest to your item
        /// </summary>
        /// <param name="enumerable"></param>
        /// <param name="item"></param>
        /// <returns>The value of the element that's closest to yours. 0 if not found.</returns>
        public int ClosestItem(IEnumerable<int> enumerable, int item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Using foreach loop, returns the farthest item from the enumerable.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <param name="item"></param>
        /// <returns>The value of the element that's the farthest from your item; 0 if the enumerable is null or empty</returns>
        public int FarthestItem(IEnumerable<int> enumerable, int item)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Using foreach loop and given an enumerable of ints, return the difference between the largest and smallest values from the enumerable.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <returns>The big difference; return 0 if enumerable is null or empty.</returns>
        public int BigDiff(IEnumerable<int> enumerable)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// We'll say that a value is "everywhere" in an enumerable if for every pair of adjacent elements in the enumerable, at least one of the pair is that value. Using a foreach loop, return true if the given value is everywhere in the enumerable.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsEverywhere(IEnumerable<int> enumerable, int value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Using a foreach loop, return the "centered" average of an enumerable of ints, which we'll say is the mean average of the values, except ignoring the largest and smallest values in the enumerable. If there are multiple copies of the smallest value, ignore just one copy, and likewise for the largest value. Use int division to produce the final average. You may assume that the enumerable is length 3 or more.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public int CenteredAverage(IEnumerable<int> enumerable)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Using a foreach loop, the method will return the average of all the even numbers that are NOT next to another even number. If there is no such number in the enumerable or if the enumerable is invalid, the method will simply return a zero.
        /// </summary>
        /// <returns>The even average.</returns>
        /// <param name="nums">Nums.</param>
        public double AloneEvenAverage(IEnumerable<int> nums)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Say that a "clump" in an enumerable is a series of 2 or more adjacent elements of the same value. Using a foreach loop, return the number of clumps in the given enumerable.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public int CountClumps(IEnumerable<int> enumerable)
        {
            throw new NotImplementedException();
        }
    }
}
