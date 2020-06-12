using System;
using System.Collections.Generic;

namespace linkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] words =
            { "the", "fox", "jumps", "over", "the", "dog" };
            
            PrintReversely.V1(new LinkedList<string>(words));
            
            Console.WriteLine();
            
            PrintReversely.V2(new LinkedList<string>(words));

            Console.WriteLine();
            
            PrintReversely.V3(new LinkedList<string>(words));
        }
    }
}
