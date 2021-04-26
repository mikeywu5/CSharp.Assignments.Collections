using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Dict
{
    public class Map2
    {
        /// <summary>
        /// Given an array of strings, return a Dictionary<string, int> containing a key for every different string in the array, always with the value 0. For example the string "hello" makes the pair "hello":0. We'll do more complicated counting later, but for this problem the value is simply 0.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, int> Word0(string[] strings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of strings, return a Dictionary<string, int> containing a key for every different string in the array, and the value is that string's length.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, int> WordLen(string[] strings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of non-empty strings, create and return a Dictionary<string, string> as follows: for each string add its first character as a key with its last character as the value.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, string> Pairs(string[] strings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The classic word-count algorithm: given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the number of times that string appears in the array.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, int> WordCount(string[] strings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of non-empty strings, return a Dictionary<string, string> with a key for every different first character seen, with the value of all the strings starting with that character appended together in the order they appear in the array.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, string> FirstChar(string[] strings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loop over the given array of strings to build a result string like this: when a string appears the 2nd, 4th, 6th, etc. time in the array, append the string to the result. Return the empty string if no string appears a 2nd time.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public string WordAppend(string[] strings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of strings, return a Dictionary<String, bool> where each different string is a key and its value is true if that string appears 2 or more times in the array.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, bool> WordMultiple(string[] strings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// We'll say that 2 strings "match" if they are non-empty and their first chars are the same. Loop over and then return the given array of non-empty strings as follows: if a string matches an earlier string in the array, swap the 2 strings in the array. When a position in the array has been swapped, it no longer matches anything. Using a Dictionary, this can be solved making just one pass over the array. More difficult than it looks.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public string[] AllSwap(string[] strings)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// We'll say that 2 strings "match" if they are non-empty and their first chars are the same. Loop over and then return the given array of non-empty strings as follows: if a string matches an earlier string in the array, swap the 2 strings in the array. A particular first char can only cause 1 swap, so once a char has caused a swap, its later swaps are disabled. Using a Dictionary, this can be solved making just one pass over the array. More difficult than it looks.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public string[] FirstSwap(string[] strings)
        {
            throw new NotImplementedException();
        }
    }
}
