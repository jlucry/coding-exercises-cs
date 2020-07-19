namespace binaryTree
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public T Value{get; set;}

        public Node<T> Parent {get; set;}
        public Node<T> ChildLeft {get; set;}
        public Node<T> ChildRight {get; set;} 

        public void SetChildren(Node<T> left, Node<T> right)
        {
            ChildLeft = left;
            left.Parent = this;
            ChildRight = right;
            right.Parent = this;
        }
    }
}