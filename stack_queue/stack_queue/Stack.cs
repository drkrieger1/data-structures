using System;
using System.Collections.Generic;
using System.Text;

namespace stack_queue
{
    class Stack : LinkedList
    {
        public void Add(object data)
        {
            FindTail().Next = new Node(data);
        }
        public void Pop(object data)
        {
            FindTail();
        }
    }
}
