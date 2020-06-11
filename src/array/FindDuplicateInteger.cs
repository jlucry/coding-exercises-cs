using System;

namespace array
{

    // Find a duplicate from an array of n integers. Integers are between 0 and n-1.
    public static class FindDuplicateInterger
    {
        // Use a hashtable to store occurence of the array integers 
        public static int V1(int[] source)
        {
            int result = -1;
            int lenght = source.Length;

            int[] hash = new int[lenght];

            for(int i=0; i<lenght; i++)
            {
                hash[i] =0;
            }

            for(int i=0; i<lenght; i++)
            {
                int item = source[i];

                if(item < 0 || item >= lenght)
                {
                    throw new ArgumentOutOfRangeException(item.ToString());
                }

                hash[item]++;

                if(hash[item] > 1)
                {
                    return item;
                }
            }

            return result;
        }


        // Sort the integers within the source array by swapping the value to the index value.
        public static int V2(int[] source)
        {
            int result = -1;
            int lenght = source.Length;

            for(int i=0; i<lenght; i++)
            {
                int item = source[i];

                if(item < 0 || item >= lenght)
                {
                    throw new ArgumentOutOfRangeException(item.ToString());
                }
                
                while(item != i)
                {
                    if(item == source[item])
                    {
                        return item;
                    }

                    int temp = source[item];
                    source[item] = item;
                    item = temp;
                }
            }

            return result;
        }
    }
}