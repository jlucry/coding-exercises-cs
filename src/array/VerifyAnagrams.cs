using System;

namespace array
{
    /// <summary>
    /// (80) If two words have the same characters and the occurence number of each character is also identical respectively,
    /// they are anagrams. The only difference between a pair of anagrams is the order of characters. 
    /// For example "silent" and "listen", "evil" and "live" are two pair of anagrams.
    /// Please implement a function to verify wheter two words are a pair of anagrams.
    /// </summary>
    public static class VerifyAnagrams
    {
        public static bool V1(string word1, string word2)
        {
            if(word1.Length != word2.Length)
            {
                return false;
            }

            int[] hashWord1 = new int[256];
            int[] hashWord2 = new int[256];

            for(int i=0; i<256; i++)
            {
                hashWord1[i] = 0;
                hashWord2[i] = 0;
            }

            int lenght = word1.Length;

            for(int i=0; i<lenght; i++)
            {
                int word1Unicode = word1[i];
                int word2Unicode = word2[i];

                hashWord1[word1Unicode]++;
                hashWord2[word2Unicode]++;
            }

            for(int i=0; i<256; i++)
            {
                if(hashWord1[i] != hashWord2[i])
                {
                    return false;
                }
            }

            return true;
        } 
    }
}