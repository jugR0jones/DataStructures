using System.Collections.Generic;

namespace DataStructures.Sorting
{
    public class BubbleSort
    {
        /// <summary>
        /// Sort the list of items in ascending order
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<string> Sort(List<string> input) {
            List<string> output = new List<string>(input);

            for(int i=0; i < output.Count-1; i++)
            {
                for(int j=i; j < output.Count; j++) {
                    if(output[i].CompareTo(output[j]) > 0)
                    {
                        string tmpString = output[i];
                        output[i] = output[j];
                        output[j] = tmpString;
                    }
                }
            }

            return output;
        }

        /// <summary>
        /// Make use of the generic method below to sort the items in descending order
        /// </summary>
        /// <param name="input">A list of strings to sort.</param>
        /// <returns>A sorted copy of the list of items.</returns>
        public static List<string> SortDescending(List<string> input) {
            return BubbleSort.Sort(input, (a, b) => {
                return (a.CompareTo(b) < 0);
            });
        }

        /// <summary>
        /// Make use of the generic method below to sort the items in ascending order. Case is taken into account.
        /// </summary>
        /// <param name="input">A list of strings to sort.</param>
        /// <returns>A sorted copy of the list of items.</returns>
        public static List<string> SortCaseInsensitive(List<string> input) {
            return BubbleSort.Sort(input, (a, b) => {
                return (string.Compare(a, b, true) > 0);
            });
        }

        /// <summary>
        /// Defines the function used to determine if the two input strings should be switched around.
        /// </summary>
        /// <param name="a">The first string</param>
        /// <param name="b">The string that will be compared to the first string</param>
        /// <returns>TRUE if the strings should be switched around. FALSE otherwise.</returns>
        public delegate bool StringComparisonLambda(string a, string b);

        /// <summary>
        /// Gemeric implementation of the BubbleSort algorithm where the condition used to switch strings is passed in as a lambda function.
        /// </summary>
        /// <param name="input">A list of strings to sort.</param>
        /// <returns>A sorted copy of the list of items.</returns>
        /// <returns></returns>
        public static List<string> Sort(List<string> input, StringComparisonLambda lambda) {
            List<string> output = new List<string>(input);

            for(int i=0; i < output.Count-1; i++)
            {
                for(int j=i; j < output.Count; j++) {
                    if(lambda(output[i], output[j]))
                    {
                        string tmpString = output[i];
                        output[i] = output[j];
                        output[j] = tmpString;
                    }
                }
            }

            return output;
        }
    }
}