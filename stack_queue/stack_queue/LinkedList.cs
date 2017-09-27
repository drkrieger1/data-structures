using System;
using System.Collections.Generic;
using System.Text;

namespace stack_queue
{
   class LinkedList
    {   
        public Node head = new Node(null);
        
        
        public Node FindTail()
        {
            Node curr = head;
            
            while (curr.Next != null)
            {
                curr = curr.Next;
            }
            return curr;
        }
        public void Print()
        {
            Node curr = head;
            Console.Write(curr.Data);

            while(curr != null)
            {
                Console.Write("->");
                Console.Write(curr.Data);
                curr = curr.Next; 
            }
            Console.Write("-> end");
        }
    }
}
