
using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            string sentence = "Hello, I want you to remove some letters. Thank!";
            string toRemove = "aeiouy";
            
            Console.WriteLine(sentence);
            Console.WriteLine(toRemove);

            string result = RemoveCharacters.RunEnhanced(sentence, toRemove);
            Console.WriteLine(result+":"+result.Length);
            result = RemoveCharacters.RunBasic(sentence, toRemove);
            Console.WriteLine(result+":"+result.Length);

            sentence = "Hello google go fast";
            Console.WriteLine(sentence);
            result = DeduplicateCharacters.RunBasic(sentence);
            Console.WriteLine(result+":"+result.Length);

            sentence = "Hello google go fast";
            Console.WriteLine(sentence);
            result = DeduplicateCharacters.V2(sentence);
            Console.WriteLine(result+":"+result.Length);

            string word1 = "silent";
            string word2 = "listeen";

            Console.WriteLine($"{word1} and {word2} are anagrams: {VerifyAnagrams.V1(word1, word2)}");

            int[] source = new int[]{1,2,4,5,4,5};
            int result = FindDuplicateInterger.V2(source);
            Console.WriteLine(result);
            */

            int[] source = new int[]{1,2,4,6,8,9};
            bool result = BinarySearchInterger.V2(source, 8);

            Console.WriteLine(result);

        }
    }
}
