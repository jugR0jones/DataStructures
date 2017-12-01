using System.Collections.Generic;

namespace DataStructures.Sorting
{
    public class SortingDemonstration : IDemonstration
    {
        public override void RunAll()
        {
            List<string> comparisonSortInputs = new List<string>() {
                "abcdefg",
                "abcdegf",
                "abcdgfe",
                "aaaaaaa",
                "aaabccd",
                "afcbdea"
            };

            List<int> integerSortInputs = new List<int>() {
                1,2,3,4,5,6,7,8,9,10,13,11,12
            };

            
        }

        // Comparison Sorts

        public List<string> MergeSort(List<string> input)
        {
            return new List<string>();
        }

        public string[] MergeSort(string[] input)
        {
            return new string[10];
        }

        // TODO: Can we add a generic version

        public List<string> InsertionSort(List<string> input) 
        {
            return new List<string>();
        }

        public List<string> BubbleSort(List<string> input)
        {
            return new List<string>();
        }

        public List<string> QuickSort(List<string> intput)
        {
            return new List<string>();
        }

        public List<string> HeapSort(List<string> input)
        {
            return new List<string>();
        }

        // Integer Sorts

        public List<int> CountingSort(List<int> input)
        {
            return new List<int>();
        }

        public List<int> RadixSort(List<int> input)
        {
            return new List<int>();
        }
    }
}