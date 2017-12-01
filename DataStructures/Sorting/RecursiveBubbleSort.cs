using System.Collections.Generic;

namespace DataStructures.Sorting {

    public class RecursiveBubbleSort {

        #region String Implementation

        /// <summary>
        /// Performs a recursive bubble sort. This is done in place, meaning the input array will change.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static void Sort (ref List<string> input, int n) {
            if (n == 1) {
                // No point in continuing because there is nothing to sort.
                return ;
            }

            for (int i = 0; i < n - 1; i++) {
                if (input[i].CompareTo (input[i + 1]) > 0) {
                    string tmpString = input[i + 1];
                    input[i + 1] = input[i];
                    input[i] = tmpString;
                }
            }

            RecursiveBubbleSort.Sort (ref input, n - 1);
        }

        /// <summary>
        /// Make use of the generic method below to sort the items in descending order
        /// </summary>
        /// <param name="input">A list of strings to sort.</param>
        /// <returns>A sorted copy of the list of items.</returns>
        public static void SortDescending (ref List<string> input) {
            RecursiveBubbleSort.Sort (ref input, input.Count, (a, b) => {
                return (a.CompareTo (b) < 0);
            });
        }

        /// <summary>
        /// Make use of the generic method below to sort the items in ascending order. Case is taken into account.
        /// </summary>
        /// <param name="input">A list of strings to sort.</param>
        /// <returns>A sorted copy of the list of items.</returns>
        public static void SortCaseInsensitive (ref List<string> input) {
            RecursiveBubbleSort.Sort (ref input, input.Count, (a, b) => {
                return (string.Compare (a, b, true) > 0);
            });
        }

        /// <summary>
        /// Defines the function used to determine if the two input strings should be switched around.
        /// </summary>
        /// <param name="a">The first string</param>
        /// <param name="b">The string that will be compared to the first string</param>
        /// <returns>TRUE if the strings should be switched around. FALSE otherwise.</returns>
        public delegate bool StringComparisonLambda (string a, string b);

        /// <summary>
        /// Gemeric implementation of the BubbleSort algorithm where the condition used to switch strings is passed in as a lambda function.
        /// </summary>
        /// <param name="input">A list of strings to sort.</param>
        /// <returns>A sorted copy of the list of items.</returns>
        /// <returns></returns>
        public static void Sort (ref List<string> input, int n, StringComparisonLambda lambda) {
            if (n == 1) {
                return ;
            }

            for (int i = 0; i < n - 1; i++) {
                if (lambda (input[i], input[i])) {
                    string tmpString = input[i];
                    input[i] = input[i];
                    input[i] = tmpString;
                }
            }

            RecursiveBubbleSort.Sort (ref input, n - 1, lambda);
        }

        #endregion

        #region Integer Implementation

        public static void Sort (ref List<int> input, int n) {
            if (n == 1) {
                return ;
            }

            for (int i = 0; i < n - 1; i++) {
                if (input[i] > input[i + 1]) {
                    int tmpInt = input[i + 1];
                    input[i + 1] = input[i];
                    input[i] = tmpInt;
                }
            }

            RecursiveBubbleSort.Sort (ref input, n - 1);
        }

        /// <summary>
        /// Make use of the generic method below to sort the items in descending order
        /// </summary>
        /// <param name="input">A list of strings to sort.</param>
        /// <returns>A sorted copy of the list of items.</returns>
        public static void SortDescending (ref List<int> input) {
            RecursiveBubbleSort.Sort (ref input, input.Count, (a, b) => {
                return (a.CompareTo (b) < 0);
            });
        }

        /// <summary>
        /// Defines the function used to determine if the two input strings should be switched around.
        /// </summary>
        /// <param name="a">The first string</param>
        /// <param name="b">The string that will be compared to the first string</param>
        /// <returns>TRUE if the strings should be switched around. FALSE otherwise.</returns>
        public delegate bool IntegerComparisonLambda (int a, int b);

        /// <summary>
        /// Gemeric implementation of the BubbleSort algorithm where the condition used to switch strings is passed in as a lambda function.
        /// </summary>
        /// <param name="input">A list of strings to sort.</param>
        /// <returns>A sorted copy of the list of items.</returns>
        /// <returns></returns>
        public static void Sort (ref List<int> input, int n, IntegerComparisonLambda lambda) {
            if (n == 1) {
                return ;
            }

            for (int i = 0; i < n - 1; i++) {
                if (lambda (input[i], input[i])) {
                    int tmpInt = input[i];
                    input[i] = input[i];
                    input[i] = tmpInt;
                }
            }

            RecursiveBubbleSort.Sort (ref input, n - 1, lambda);
        }

        #endregion
    }
}