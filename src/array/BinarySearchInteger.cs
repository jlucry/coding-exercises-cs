using System;

namespace array
{
    public static class BinarySearchInterger
    {
        /// <summary>
        /// Intuitive first though
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool V1(int[] source, int target)
        {
            int length = source.Length-1;
            int indexMid = length/2;

            int min = source[0];
            int max = source[length];
            int mid = source[length/2];

            while(min != max)
            {
                if(target == mid)
                {
                    return true;
                }

                if(target > mid)
                {
                    min = mid;
                    indexMid = indexMid + length/4;
                    mid = source[indexMid];
                }
                else
                {
                    max = mid;
                    indexMid = length/4;
                    mid = source[indexMid];
                }
            }

            return false;
        }

        /// <summary>
        /// Optimized
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool V2(int[] source, int target)
        {
            int min = 0;
            int max = source.Length - 1;

            while(min<=max)
            {
                int mid = (min + max)/2;
                
                if(target == source[mid])
                {
                    return true;
                }
                else if(target > source[mid])
                {   
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return false;
        }
    }
}