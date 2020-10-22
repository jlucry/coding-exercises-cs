using System;
using System.Collections;
using System.Collections.Generic;

namespace stackQueue
{
    /// <summary>
    /// Please design a queue with two stacks and implements methods to enqueue and dequeue items.
    /// </summary>
    public class QueueWithTwoStacks
    {
        private readonly Stack stack1;
        private readonly Stack stack2;

        public QueueWithTwoStacks()
        {
            stack1 = new Stack();
            stack2 = new Stack();
        }
           
        public void Enqueue (object obj)
        {
            int stack2Count=stack2.Count;
            
            for(int i=0; i<stack2Count; i++)
            {
                stack1.Push(stack2.Pop());
            }

            stack1.Push(obj);
        }

        public object Dequeue()
        {
            int stack1Count = stack1.Count;

            for(int i=0; i<stack1Count; i++)
            {
                stack2.Push(stack1.Pop());
            }

            return stack2.Pop();
        }

        public static implicit operator QueueWithTwoStacks(QueueWithTwoStacks<int> v)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Optimized implementation of a typed queue with two stacks.
    /// </summary>
    /// <typeparam name="T">Type of the objects to queue</typeparam>
    public class QueueWithTwoStacks<T>
    {
        private Stack<T> stack1 = new Stack<T>();
        private Stack<T> stack2 = new Stack<T>();

        public void Enqueue (T obj)
        {
            stack1.Push(obj);
        }

        public T Dequeue()
        {
            if(stack2.Count == 0)
            {
                while(stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            if(stack2.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return stack2.Pop();
        }
    }
}