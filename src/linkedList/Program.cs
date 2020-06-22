using System;
using System.Collections.Generic;

namespace linkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
            string[] words = { "the", "fox", "jumps", "over", "the", "dog" };
            
            PrintReversely.V1(new LinkedList<string>(words));         
            Console.WriteLine();
                
            PrintReversely.V2(new LinkedList<string>(words));
            Console.WriteLine();
                
            PrintReversely.V3(new LinkedList<string>(words));  
            LinkedList<int> numbers = new LinkedList<int>(new int[]{2, 4, 1, 3, 5});
            foreach(int item in numbers)
            {
                Console.Write(item+"->");
            }

            Console.WriteLine();
            foreach(int item in InsertSort.V1(numbers))
            {
                Console.Write(item+"->");
            }

            Console.WriteLine();
            foreach(int item in InsertSort.V2(numbers))
            {
                Console.Write(item+"->");
            }

            LinkedList<int> numbers1 = new LinkedList<int>(new int[]{1, 3, 5, 7});
            foreach(int item in numbers1)
            {
            Console.Write(item+"->");
            }

            Console.WriteLine();
            LinkedList<int> numbers2 = new LinkedList<int>(new int[]{2, 4, 6, 7, 9});
            foreach(int item in numbers2)
            {
                Console.Write(item+"->");
            }

            Console.WriteLine();
            LinkedList<int> mergeNumbers = MergeSorted.V2(numbers1, numbers2); 
            foreach(int item in mergeNumbers)
            {
                Console.Write(item+"->");
            }
            */

            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            node1.Next = node2;
            Node<int> node3 = new Node<int>(3);
            node2.Next = node3;
            Node<int> node4 = new Node<int>(4);
            node3.Next = node4;
            Node<int> node5 = new Node<int>(5);
            node4.Next = node5;
            Node<int> node6 = new Node<int>(6);
            node5.Next = node6;
            node6.Next = node3; 

            bool result = Loop.HasLoop(node1);
            Console.WriteLine("Has Loop:" + result);
            Console.WriteLine("Entry node of loop:" + Loop.EntryNodeOfLoop(node1).Value);
        }
    }
}
