using System;
using System.Collections.Generic;

namespace linkedList
{
    public static class PrintReversely
    {
        // Use the api double linked list capabilities Last and  Previous
        public static void V1(LinkedList<string> list)
        {
            LinkedListNode<string> current = list.Last;

            while(current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Previous;
            } 
        }

        // Consider the list as a single linked list and use a stack
        public static void V2(LinkedList<string> list)
        {
            LinkedListNode<string> current = list.First;
            Stack<string> stack = new Stack<string>();

            while(current != null)
            {
                stack.Push(current.Value);
                current = current.Next;
            }

            while(stack.Count != 0)
            {
               Console.WriteLine(stack.Pop());
            }
        }

        // Use recursivity
        public static void V3(LinkedList<string> list)
        {
           printRecursively(list.First);
        }

        private static void printRecursively(LinkedListNode<string> node)
        {
            if(node != null)
            {
                printRecursively(node.Next);
                
                Console.WriteLine(node.Value);
            }
        }
    }
}