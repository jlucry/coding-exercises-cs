using System;
using System.Collections;

namespace stackQueue
{
    /// <summary>
    /// Please design a stack with two queues and implement the methods to push and pop items.
    /// </summary>
    public class StackWithTwoQueues
    {
        private Queue queue1 = new Queue();
        private Queue queue2 = new Queue();

        public void Push(object obj)
        {
            if(queue1.Count > 0)
            {
                queue1.Enqueue(obj);
            }
            else if(queue2.Count >0)
            {
                queue2.Enqueue(obj);
            }
            else
            {
                queue1.Enqueue(obj);
            }
        }

        public object Pop()
        {
            if(queue1.Count > 0 && queue2.Count == 0)
            {
                while(queue1.Count > 1)
                {
                    queue2.Enqueue(queue1.Dequeue());
                }

                return queue1.Dequeue();
            }

            if(queue2.Count > 0 && queue1.Count == 0)
            {
                while(queue2.Count > 1)
                {
                    queue1.Enqueue(queue2.Dequeue());
                }

                return queue2.Dequeue();
            }

            throw new InvalidOperationException();
        }
    }
}