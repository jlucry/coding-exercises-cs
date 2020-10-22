using System;

namespace array
{  
    /// <summary>
    /// (81) If an element at the left side is greater than another element at the right side,
    /// they form a "reversed pair" in an array. How do you get a count of reversed pairs?
    /// For exemple, there are five reversed pairs in the array {7,5,6,4}, which are (7,5), (7,6), (7,4), (6,4) 
    /// </summary>
    public static class CountReversedPairs
    {
        public static int V1(int[] source)
        {
            int result = 0;

            for(int i=0; i<source.Length; i++)
            {
                for(int j=i+1; j<source.Length; j++)
                {
                    if(source[i]>source[j])
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}