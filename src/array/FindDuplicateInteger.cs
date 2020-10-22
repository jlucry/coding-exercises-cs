using System;

namespace array
{    
    /// <summary>
    /// (6) An array contains n numbers ranging from 0 and n-1. There are some numbers duplicated in the array.
    /// It is not clear how many numbers are duplicated or many times a number gets duplicated.
    /// How do you find a duplicated number in the array? For example if an array of length 7 contains the numbers {2,3,1,0,2,5,3}
    /// the implemented function should return either 2 or 3.
    /// </summary>
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