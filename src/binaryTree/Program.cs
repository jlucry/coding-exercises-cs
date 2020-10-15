using System;
using System.Collections.Generic;

namespace binaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary search tree sample
            Node<int> root = new Node<int>(10);
            Node<int> child1 = new Node<int>(6);
            Node<int> child2 = new Node<int>(14);
            root.SetChildren(child1, child2);
            Node<int> child3 = new Node<int>(4);
            Node<int> child4 = new Node<int>(8);
            child1.SetChildren(child3, child4);
            Node<int> child5 = new Node<int>(12);
            Node<int> child6 = new Node<int>(16);
            child2.SetChildren(child5, child6);

            Console.WriteLine("InOrder traversal");
            List<int> results = Traversals.InOrder(root);

            foreach(int result in results)
            {
                Console.Write(result + " ");
            }    

            Console.WriteLine();
            Console.WriteLine("PreOrder traversal");

            results = Traversals.PreOrder(root);

            foreach(int result in results)
            {
                Console.Write(result + " ");
            }  

            Console.WriteLine();
            Console.WriteLine("PostOrder traversal");
            
            results = Traversals.PostOrder(root);

            foreach(int result in results)
            {
                Console.Write(result + " ");
            } 
        }
    }
}
