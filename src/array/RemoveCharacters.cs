using System;
using System.Text;

namespace array
{
    /// <summary>
    /// (78) Given two strings, how do you delete characters contained in the second string from the first string?
    /// For example, if all characters in the string "aeiou" are deleted from the string "We are students.",
    /// the result is "W r stdnts.".
    /// </summary>
    public static class RemoveCharacters
    {
        public static string RunEnhanced(string source, string letters)
        {
            int[] ascii = new int[256];
            
            for(int i=0; i<256; i++)
            {
                ascii[i] = 0;
            }

            for(int i=0; i<letters.Length; i++)
            {
                int code = letters[i];
                ascii[code]++;
            }

            StringBuilder builder = new StringBuilder();

            for(int i=0; i<source.Length; i++)
            {
               int code = source[i];
               if(ascii[code]==0)
               {
                   builder.Append(source[i]);
               }
            }

            return builder.ToString();           
        }

        public static string RunBasic(string source, string letters)
        {
            int[] ascii = new int[256];
            
            for(int i=0; i<256; i++)
            {
                ascii[i] = 0;
            }

            for(int i=0; i<letters.Length; i++)
            {
                int code = letters[i];
                ascii[code]++;
            }

            char[] result = new char[source.Length];
            int j=0;

            for(int i=0; i<source.Length; i++)
            {
               int code = source[i];

               if(ascii[code] == 0)
               {
                   result[j] = source[i];
                   j++;
               }
            }

            return new string(result);           
        }
    }
}