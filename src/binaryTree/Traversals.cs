using System.Collections.Generic;
using System;

namespace binaryTree
{
    public static class Traversals
    {
        
         public static List<int> InOrder(Node<int> root)
        {
            List<int> results = new List<int>();

            InOrderCore(root, results);

            return results;
        }

        private static void InOrderCore(Node<int> node, List<int> results)
        {
            if(node == null)
            {
                return;
            }

            // Traverse left tree
            InOrderCore(node.ChildLeft, results);

            results.Add(node.Value);
            
            // Traverse right tree
            InOrderCore(node.ChildRight, results);
        }

        public static List<int> PreOrder(Node<int> root)
        {
            List<int> results = new List<int>();

            PreOrderCore(root, results);

            return results;
        }

        private static void PreOrderCore(Node<int> node, List<int> results)
        {
            if(node == null)
            {
                return;
            }

            results.Add(node.Value);

            // Traverse left tree
            PreOrderCore(node.ChildLeft, results);
            
            // Traverse right tree
            PreOrderCore(node.ChildRight, results);
        }


        public static List<int> PostOrder(Node<int> root)
        {
            List<int> results = new List<int>();

            PostOrderCore(root, results);

            return results;
        }

        private static void PostOrderCore(Node<int> node, List<int> results)
        {
            if(node == null)
            {
                return;
            }

            // Traverse left tree
            PostOrderCore(node.ChildLeft, results);
            
            // Traverse right tree
            PostOrderCore(node.ChildRight, results);

            results.Add(node.Value);
        }
    }
}