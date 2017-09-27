using System;
using System.Collections.Generic;
using System.Text;

namespace stack_queue
{
    class Queue : LinkedList
    {
        public void AddQueue(object data)
        {
            FindTail().Next = new Node(data);    
        }
        public void DeQueue()
        {   
            if(head.Next == null)
            {
                Console.WriteLine("Queue is empty");
            }
            head.Next = head.Next.Next;
        }
    }
}
