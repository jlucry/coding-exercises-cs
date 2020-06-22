using System;
using System.Collections.Generic;

namespace linkedList
{
    public static class InsertSort
    {
        /// <summary>
        /// Intuitve first though to sort values from a linked list
        /// </summary>
        /// <param name="list"></param>
        public static LinkedList<int> V1(LinkedList<int> list)
        {
            LinkedListNode<int> first = list.First;         
            LinkedListNode<int> unsorted = first.Next;

            LinkedList<int> sortedList = new LinkedList<int>();
            sortedList.AddFirst(new LinkedListNode<int>(first.Value));

            while(unsorted != null)
            {
                if(unsorted.Value <= sortedList.First.Value)
                {              
                    sortedList.AddBefore(sortedList.First, new LinkedListNode<int>(unsorted.Value));
                }
                else
                {
                    LinkedListNode<int> sorted = sortedList.First;

                    bool exit = false;
                    while(sorted != null && exit == false)
                    {
                        if(unsorted.Value <= sorted.Value)
                        {
                            sortedList.AddBefore(sorted, new LinkedListNode<int>(unsorted.Value));
                            exit = true;
                        }
                        else if(sorted.Next == null)
                        {
                            sortedList.AddAfter(sorted, new LinkedListNode<int>(unsorted.Value));
                            sorted = sorted.Next;
                        }

                        sorted = sorted.Next;
                    }
                }

                unsorted = unsorted.Next;
            }

            return sortedList;
        }

        /// <summary>
        /// Create a new sorted list. Find the node where to insert the items from the unsorted list. 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static LinkedList<int> V2(LinkedList<int> list)
        {
            LinkedListNode<int> first = list.First;         
            LinkedListNode<int> unsorted = first.Next;

            LinkedList<int> sortedList = new LinkedList<int>();
            sortedList.AddFirst(new LinkedListNode<int>(first.Value));

            while(unsorted != null)
            {
                LinkedListNode<int> sorted = sortedList.First;
                
                if(unsorted.Value <= sorted.Value)
                {              
                    sortedList.AddBefore(sorted, new LinkedListNode<int>(unsorted.Value));
                }
                else
                {                   
                    while(sorted.Next != null && unsorted.Value > sorted.Value)
                    {
                        sorted = sorted.Next;
                    }

                    if(sorted.Value <= unsorted.Value)
                    {
                        sortedList.AddAfter(sorted, new LinkedListNode<int>(unsorted.Value));
                    }
                    else
                    {
                        sortedList.AddBefore(sorted, new LinkedListNode<int>(unsorted.Value));
                    }
                }

                unsorted = unsorted.Next;
            }

            return sortedList;
        }
    }
}