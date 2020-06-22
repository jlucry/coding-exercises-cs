namespace linkedList
{
    public static class Loop
    {
        /// <summary>
        /// Check if the linked list has a loop. Instantiate two nodes referencing head one slow and one fast.
        /// Check if they meet at thome point. 
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        private static Node<int> MeetingNode(Node<int> head)
        {
            if(head == null)
            {
                return null;
            }

            Node<int> slow = head.Next;

            if(slow == null)
            {
                return null;
            }

            Node<int> fast = slow.Next;

            while(fast != null || slow != null)
            {
                if(slow == fast)
                {
                    return slow;
                }
                
                slow = slow.Next;
                fast = fast.Next;

                if(fast != null)
                {
                    fast = fast.Next;
                }
            }

            return null;
        }

        public static bool HasLoop(Node<int> head)
        {
            return MeetingNode(head) != null ? true : false; 
        }

        /// <summary>
        /// Find the Entry node of a loop. 
        /// Get the number of nodes in loop and then meet the loop count node and head.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static Node<int> EntryNodeOfLoop(Node<int> head)
        {
            Node<int> meetingNode = MeetingNode(head);

            if(meetingNode == null)
            {
                return null;
            }

            // Get the number of nodes in loop.
            int loopNodesCount = 1;
            Node<int> node1 = meetingNode.Next;

            while(node1 != meetingNode)
            {
                node1 = node1.Next;
                loopNodesCount++;
            }

            // Move foward to the loop count node
            node1 = head;

            for(int i= 0; i < loopNodesCount; i++)
            {
                node1 = node1.Next;
            }

            // Find the entry node loop by metting the loop count node and head
            Node<int> node2 = head;

            while(node1 != node2)
            {
                node1 = node1.Next;
                node2 = node2.Next;
            }

            return node1;
        }
    }
}