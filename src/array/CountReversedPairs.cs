using System;

namespace array
{  
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