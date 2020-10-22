using System;
using System.Text;

namespace array
{
    /// <summary>
    /// (79) Please implement a function to delete all duplicated characters in a string and keep only the first occurrence of each character left.
    /// For example, if the input is string "google", the result after deletion is "gole".
    /// </summary>
    public static class DeduplicateCharacters
    {
        public static string RunBasic(string source)
        {
            int[] ascii = new int[256];
            
            for(int i=0; i<256; i++)
            {
                ascii[i] = 0;
            } 

            int resultLenght = 0;

            for(int i=0; i<source.Length ;i++)
            {
                int charCode = source[i];
                ascii[charCode]++;

                if(ascii[charCode]==1)
                {
                    resultLenght++;
                }
            }

            char[] result = new char[resultLenght];

            int j = 0;
            for(int i=0; i<source.Length ;i++)
            {
                int charCode = source[i];

                if(ascii[charCode]>=1)
                {
                    result[j] = source[i];
                    ascii[charCode]=0;
                    j++;
                }
            }

            return new string(result);
        }

        public static string V2(string source)
        {
            int[] ascii = new int[256];
            
            for(int i=0; i<256; i++)
            {
                ascii[i] = 0;
            }

            StringBuilder result = new StringBuilder();
            
            foreach (char item in source)
            {
                int charCode = item;
                
                ascii[charCode]++;

                if(ascii[charCode] == 1)
                {
                    result.Append(item);
                }
            }

            return result.ToString();
        }
    }
}
