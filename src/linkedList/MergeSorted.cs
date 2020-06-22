using System.Collections.Generic;

namespace linkedList
{
    public static class MergeSorted
    {
        /// <summary>
        /// Merge 2 sorted linked lists. Intuitive iterative thought.
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static LinkedList<int> V1(LinkedList<int> list1, LinkedList<int> list2)
        {
            LinkedListNode<int> list1Head = list1.First;
            LinkedListNode<int> list2Head = list2.First;

            LinkedList<int> result = new LinkedList<int>();
            
            while(list1Head != null || list2Head != null)
            {
                
                if(list1Head != null && list2Head != null)
                {
                    if(list1Head.Value <= list2Head.Value)
                    {
                        result.AddLast(new LinkedListNode<int>(list1Head.Value));
                        list1Head = list1Head.Next;
                    }
                    else
                    {   
                        result.AddLast(new LinkedListNode<int>(list2Head.Value));
                        list2Head = list2Head.Next;
                    }  
                }
                else if(list1Head == null && list2Head != null)
                {
                        result.AddLast(new LinkedListNode<int>(list2Head.Value));
                        list2Head = list2Head.Next;
                }
                else if(list1Head != null && list2Head == null)
                {
                        result.AddLast(new LinkedListNode<int>(list1Head.Value));
                        list1Head = list1Head.Next;
                }
            
            }

            return result;
        }

        /// <summary>
        /// Merge 2 sorted linked lists. Recursive solution.
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static LinkedList<int> V2(LinkedList<int> list1, LinkedList<int> list2)
        {
            LinkedList<int> result = new LinkedList<int>();
            merge(result, list1.First, list2.First);

            return result;
        }

        private static void merge(LinkedList<int> result, LinkedListNode<int> list1Head, LinkedListNode<int> list2Head)
        {
            if(list1Head != null && list2Head != null)
            {
                if(list1Head.Value <= list2Head.Value)
                {
                    result.AddLast(new LinkedListNode<int>(list1Head.Value));
                    merge(result, list1Head.Next, list2Head);
                }
                else
                {   
                    result.AddLast(new LinkedListNode<int>(list2Head.Value));
                    merge(result, list1Head, list2Head.Next);
                }  
            }
            else if(list1Head == null && list2Head != null)
            {
                result.AddLast(new LinkedListNode<int>(list2Head.Value));
                merge(result, list1Head, list2Head.Next);
            }
            else if(list1Head != null && list2Head == null)
            {
                result.AddLast(new LinkedListNode<int>(list1Head.Value));
                merge(result, list1Head.Next, list2Head);
            }
        }
    }
}

