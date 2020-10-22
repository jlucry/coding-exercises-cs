using System;

namespace stackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue with two stacks intuitive");
            var queue = new QueueWithTwoStacks();
            queue.Enqueue(1);
            queue.Enqueue(2);
 
            Console.WriteLine(queue.Dequeue());

            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine("Queue with two stacks optimize");
            var queueInt = new QueueWithTwoStacks<int>();
            queueInt.Enqueue(1);
            queueInt.Enqueue(2);
 
            Console.WriteLine(queueInt.Dequeue());

            queueInt.Enqueue(3);
            queueInt.Enqueue(4);

            Console.WriteLine(queueInt.Dequeue());
            Console.WriteLine(queueInt.Dequeue());
            Console.WriteLine(queueInt.Dequeue());

           Console.WriteLine("Stack with two queues");
            var stack = new StackWithTwoQueues();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());

            stack.Push(4);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
