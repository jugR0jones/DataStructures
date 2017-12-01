using System.Collections.Generic;

namespace DataStructures.Sorting
{
    public class BubbleSort
    {
        public static List<string> Sort(List<string> input) {
            List<string> output = new List<string>(input);

            for(int i=0; i < output.Count; i++)
            {
                for(int j=0; j < output.Count-1; j++) {
                    if(output[i].CompareTo(output[j]) < 0)
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