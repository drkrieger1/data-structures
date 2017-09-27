using System;
using System.Collections.Generic;
using System.Text;

namespace stack_queue
{
    class Stack : LinkedList
    {
        public void Add(object data)
        {
            Node newNode = new Node(data);
            Node curr = FindTail();

            curr.Next = newNode;
            newNode.Prev = curr;
            
        }
        public void Pop()
        {
            Node current = FindTail();
            current = current.Prev;
            current.Next = null;

         
        }
    }
}
